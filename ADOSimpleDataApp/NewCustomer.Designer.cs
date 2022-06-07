namespace ADOSimpleDataApp
{
	partial class NewCustomer
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnAddFinish = new System.Windows.Forms.Button();
			this.btnAddAnotherAccount = new System.Windows.Forms.Button();
			this.btnCreateAccount = new System.Windows.Forms.Button();
			this.btnPlaceOrder = new System.Windows.Forms.Button();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
			this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Account";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Customer Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Customer ID:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Create Order";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Order Date:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Order Amount:";
			// 
			// btnAddFinish
			// 
			this.btnAddFinish.Location = new System.Drawing.Point(102, 370);
			this.btnAddFinish.Name = "btnAddFinish";
			this.btnAddFinish.Size = new System.Drawing.Size(120, 23);
			this.btnAddFinish.TabIndex = 1;
			this.btnAddFinish.Text = "Finish";
			this.btnAddFinish.UseVisualStyleBackColor = true;
			this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
			// 
			// btnAddAnotherAccount
			// 
			this.btnAddAnotherAccount.Location = new System.Drawing.Point(581, 370);
			this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
			this.btnAddAnotherAccount.Size = new System.Drawing.Size(188, 23);
			this.btnAddAnotherAccount.TabIndex = 1;
			this.btnAddAnotherAccount.Text = "Add Another Account";
			this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
			this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Location = new System.Drawing.Point(351, 83);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(120, 23);
			this.btnCreateAccount.TabIndex = 1;
			this.btnCreateAccount.Text = "Create Account";
			this.btnCreateAccount.UseVisualStyleBackColor = true;
			this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
			// 
			// btnPlaceOrder
			// 
			this.btnPlaceOrder.Location = new System.Drawing.Point(351, 238);
			this.btnPlaceOrder.Name = "btnPlaceOrder";
			this.btnPlaceOrder.Size = new System.Drawing.Size(120, 23);
			this.btnPlaceOrder.TabIndex = 1;
			this.btnPlaceOrder.Text = "Place Order";
			this.btnPlaceOrder.UseVisualStyleBackColor = true;
			this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(124, 84);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(193, 23);
			this.txtCustomerID.TabIndex = 2;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(124, 52);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(193, 23);
			this.txtCustomerName.TabIndex = 2;
			// 
			// dtpOrderDate
			// 
			this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpOrderDate.Location = new System.Drawing.Point(124, 236);
			this.dtpOrderDate.Name = "dtpOrderDate";
			this.dtpOrderDate.Size = new System.Drawing.Size(114, 23);
			this.dtpOrderDate.TabIndex = 3;
			// 
			// numOrderAmount
			// 
			this.numOrderAmount.Location = new System.Drawing.Point(124, 201);
			this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numOrderAmount.Name = "numOrderAmount";
			this.numOrderAmount.Size = new System.Drawing.Size(114, 23);
			this.numOrderAmount.TabIndex = 4;
			// 
			// NewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.numOrderAmount);
			this.Controls.Add(this.dtpOrderDate);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.btnAddAnotherAccount);
			this.Controls.Add(this.btnPlaceOrder);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.btnAddFinish);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NewCustomer";
			this.Text = "New Account and Order";
			((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button btnAddFinish;
		private Button btnAddAnotherAccount;
		private Button btnCreateAccount;
		private Button btnPlaceOrder;
		private TextBox txtCustomerID;
		private TextBox txtCustomerName;
		private DateTimePicker dtpOrderDate;
		private NumericUpDown numOrderAmount;
	}
}