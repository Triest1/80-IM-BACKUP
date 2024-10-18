using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSInventoryCreditSystem
{
    public partial class CashierCreditCustomersForm : UserControl
    {
        SqlConnection
             connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public CashierCreditCustomersForm()
        {
            InitializeComponent();

            displaycredCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displaycredCustomers();
        }

        public void displaycredCustomers()
        {
            CreditCustomersData ccData = new CreditCustomersData();

            List<CreditCustomersData> listData = ccData.allcreditCustomers();

            dataGridView1.DataSource = listData;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private float GetTotalAmountForCustomer(int customerId)
        {
            float totalAmount = 0f;

            if (checkConnection()) // Ensure the connection is valid before proceeding
            {
                try
                {
                    connect.Open(); // Open the connection

                    string query = "SELECT SUM(total_price) FROM creditCustomer WHERE customer_id = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalAmount = Convert.ToSingle(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close(); // Ensure the connection is closed after use
                }
            }

            return totalAmount;
        }

        private int getCustomerId = 0; // Field to store the selected customer ID

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["CustomerID"].Value != DBNull.Value)
                {
                    if (int.TryParse(row.Cells["CustomerID"].Value.ToString(), out getCustomerId))
                    {
                        // Set the customer ID in the text box
                        credit_ID.Text = getCustomerId.ToString();

                        // Retrieve other details (ensure these columns exist and are correctly named)
                        float totalPrice = float.Parse(row.Cells["TotalPrice"].Value.ToString());
                        float amount = float.Parse(row.Cells["Amount"].Value.ToString());
                        float change = float.Parse(row.Cells["Change"].Value.ToString());
                        DateTime date = DateTime.Parse(row.Cells["Date"].Value.ToString());

                        // Store these values in fields to use later
                        // (You can create private fields to hold these values)
                        lastTotalPrice = totalPrice;
                        lastAmount = amount;
                        lastChange = change;
                        lastPaymentDate = date;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer ID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private float lastTotalPrice;
        private float lastAmount;
        private float lastChange;
        private DateTime lastPaymentDate;

        private bool PaymentExists(int customerId)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "SELECT COUNT(*) FROM creditPayments WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Return true if a payment exists
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connect.Close();
                }
            }
            return false;
        }
        private (float TotalPrice, float AmountPaid) GetExistingPaymentDetails(int customerId)
        {
            float existingTotalPrice = 0f;
            float existingAmountPaid = 0f;

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "SELECT TotalPrice, AmountPaid FROM creditPayments WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["TotalPrice"] != DBNull.Value)
                                    existingTotalPrice = Convert.ToSingle(reader["TotalPrice"]);

                                if (reader["AmountPaid"] != DBNull.Value)
                                    existingAmountPaid = Convert.ToSingle(reader["AmountPaid"]);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return (existingTotalPrice, existingAmountPaid);
        }

        private void UpdateCreditStatus(int customerId)
        {
            var existingPaymentDetails = GetExistingPaymentDetails(customerId);

            // Check if AmountPaid is null or not equal to TotalPrice
            if (existingPaymentDetails.AmountPaid == 0 || existingPaymentDetails.AmountPaid < existingPaymentDetails.TotalPrice)
            {
                credit_status.Text = "Unpaid";
            }
            else if (existingPaymentDetails.AmountPaid == existingPaymentDetails.TotalPrice)
            {
                credit_status.Text = "Paid";
            }
        }

        private void InsertCreditPayment(int customerId, float totalPrice)
        {
            // Check if the payment already exists
            var existingPaymentDetails = GetExistingPaymentDetails(customerId);
            if (existingPaymentDetails.TotalPrice > 0)
            {
                // Display the existing TotalPrice and AmountPaid in the labels
                cashierCredCust_totalPrice.Text = $"{existingPaymentDetails.TotalPrice}"; 
                cashierCredCust_amountPaid.Text = $"{existingPaymentDetails.AmountPaid}"; 
                UpdateCreditStatus(customerId); // New line added here
                return; // Exit the method if the payment already exists
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "INSERT INTO creditPayments (CustomerID, TotalPrice, Amount, Change, PaymentDate) " +
                                   "VALUES (@CustomerID, @TotalPrice, @Amount, @Change, @PaymentDate)";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@Amount", 0); // Assuming they pay the total
                        command.Parameters.AddWithValue("@Change", 0); // Assuming no change
                        command.Parameters.AddWithValue("@PaymentDate", DateTime.Now); // Use current date

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Update the credit status after inserting a new payment
                    UpdateCreditStatus(customerId); // New line added here
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void credit_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(credit_ID.Text, out int customerId))
                {
                    // Get the total amount for this customer
                    float totalAmount = GetTotalAmountForCustomer(customerId);

                    if (totalAmount > 0)
                    {
                        // Insert the total amount into creditPayments table
                        InsertCreditPayment(customerId, totalAmount);
                    }
                    else
                    {
                        MessageBox.Show("No total price found for this customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierCredCust_amount_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(credit_ID.Text, out int customerId))
                {
                    // Retrieve the total price for the customer
                    float totalPrice = GetTotalAmountForCustomer(customerId);

                    // Check if an amount has been entered
                    if (float.TryParse(cashierCredCust_amount.Text, out float amountPaid))
                    {
                        // Check if the entered amount is greater than the total price
                        if (amountPaid > totalPrice)
                        {
                            // Calculate the change
                            float change = amountPaid - totalPrice;

                            // Display the change in the cashierOrder_change label
                            cashierCredCust_change.Text = $"{change}"; // Display change without currency
                        }
                        else
                        {
                            // Clear the change label if the amount is not greater
                            cashierCredCust_change.Text = "0.00";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


