namespace POSInventoryCreditSystem
{
    partial class CashierCreditCustomersForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.credit_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierCredCust_amount = new System.Windows.Forms.TextBox();
            this.cashierCredCust_change = new System.Windows.Forms.Label();
            this.cashierCredCust_totalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierCredCust_amountPaid = new System.Windows.Forms.Label();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.credit_status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 708);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 613);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Credit Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.credit_ID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(763, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 54);
            this.panel2.TabIndex = 2;
            // 
            // credit_ID
            // 
            this.credit_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_ID.Location = new System.Drawing.Point(213, 13);
            this.credit_ID.Name = "credit_ID";
            this.credit_ID.Size = new System.Drawing.Size(98, 29);
            this.credit_ID.TabIndex = 2;
            this.credit_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.credit_ID_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Credit ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.credit_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cashierOrder_receipt);
            this.panel3.Controls.Add(this.cashierOrder_payOrders);
            this.panel3.Controls.Add(this.cashierCredCust_amountPaid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cashierCredCust_amount);
            this.panel3.Controls.Add(this.cashierCredCust_change);
            this.panel3.Controls.Add(this.cashierCredCust_totalPrice);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(763, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 648);
            this.panel3.TabIndex = 3;
            // 
            // cashierCredCust_amount
            // 
            this.cashierCredCust_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierCredCust_amount.Location = new System.Drawing.Point(165, 228);
            this.cashierCredCust_amount.Name = "cashierCredCust_amount";
            this.cashierCredCust_amount.Size = new System.Drawing.Size(146, 26);
            this.cashierCredCust_amount.TabIndex = 28;
            this.cashierCredCust_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierCredCust_amount_KeyDown);
            // 
            // cashierCredCust_change
            // 
            this.cashierCredCust_change.AutoSize = true;
            this.cashierCredCust_change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierCredCust_change.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredCust_change.Location = new System.Drawing.Point(161, 288);
            this.cashierCredCust_change.Name = "cashierCredCust_change";
            this.cashierCredCust_change.Size = new System.Drawing.Size(40, 19);
            this.cashierCredCust_change.TabIndex = 27;
            this.cashierCredCust_change.Text = "0.00";
            // 
            // cashierCredCust_totalPrice
            // 
            this.cashierCredCust_totalPrice.AutoSize = true;
            this.cashierCredCust_totalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierCredCust_totalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredCust_totalPrice.Location = new System.Drawing.Point(167, 123);
            this.cashierCredCust_totalPrice.Name = "cashierCredCust_totalPrice";
            this.cashierCredCust_totalPrice.Size = new System.Drawing.Size(40, 19);
            this.cashierCredCust_totalPrice.TabIndex = 24;
            this.cashierCredCust_totalPrice.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(55, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Change (₱):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(55, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount (₱):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(35, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total Price (₱):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Settle Credit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(15, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Amount Paid (₱):";
            // 
            // cashierCredCust_amountPaid
            // 
            this.cashierCredCust_amountPaid.AutoSize = true;
            this.cashierCredCust_amountPaid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierCredCust_amountPaid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredCust_amountPaid.Location = new System.Drawing.Point(167, 174);
            this.cashierCredCust_amountPaid.Name = "cashierCredCust_amountPaid";
            this.cashierCredCust_amountPaid.Size = new System.Drawing.Size(40, 19);
            this.cashierCredCust_amountPaid.TabIndex = 30;
            this.cashierCredCust_amountPaid.Text = "0.00";
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(19, 475);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(280, 55);
            this.cashierOrder_payOrders.TabIndex = 31;
            this.cashierOrder_payOrders.Text = "Pay Orders";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(19, 558);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(280, 55);
            this.cashierOrder_receipt.TabIndex = 32;
            this.cashierOrder_receipt.Text = "Receipt";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(35, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Credit Status:";
            // 
            // credit_status
            // 
            this.credit_status.AutoSize = true;
            this.credit_status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_status.ForeColor = System.Drawing.Color.RoyalBlue;
            this.credit_status.Location = new System.Drawing.Point(167, 70);
            this.credit_status.Name = "credit_status";
            this.credit_status.Size = new System.Drawing.Size(110, 19);
            this.credit_status.TabIndex = 34;
            this.credit_status.Text = "Paid / Unpaid";
            // 
            // CashierCreditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierCreditCustomersForm";
            this.Size = new System.Drawing.Size(1113, 756);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox credit_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cashierCredCust_change;
        private System.Windows.Forms.Label cashierCredCust_totalPrice;
        private System.Windows.Forms.TextBox cashierCredCust_amount;
        private System.Windows.Forms.Label cashierCredCust_amountPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.Label credit_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cashierOrder_receipt;
    }
}
