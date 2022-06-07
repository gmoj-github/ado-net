namespace ADOSimpleDataApp
{
	partial class FillOrCancel
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
			this.btnFindByOrderID = new System.Windows.Forms.Button();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
			this.btnCancelOrder = new System.Windows.Forms.Button();
			this.btnFillOrder = new System.Windows.Forms.Button();
			this.btnFinishUpdates = new System.Windows.Forms.Button();
			this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Order ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnFindByOrderID
			// 
			this.btnFindByOrderID.Location = new System.Drawing.Point(247, 29);
			this.btnFindByOrderID.Name = "btnFindByOrderID";
			this.btnFindByOrderID.Size = new System.Drawing.Size(75, 23);
			this.btnFindByOrderID.TabIndex = 1;
			this.btnFindByOrderID.Text = "Find Order";
			this.btnFindByOrderID.UseVisualStyleBackColor = true;
			// 
			// txtOrderID
			// 
			this.txtOrderID.Location = new System.Drawing.Point(86, 29);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(140, 23);
			this.txtOrderID.TabIndex = 2;
			this.txtOrderID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "If filling an order, specify filled date";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// dtpFillDate
			// 
			this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFillDate.Location = new System.Drawing.Point(236, 132);
			this.dtpFillDate.Name = "dtpFillDate";
			this.dtpFillDate.Size = new System.Drawing.Size(114, 23);
			this.dtpFillDate.TabIndex = 3;
			// 
			// btnCancelOrder
			// 
			this.btnCancelOrder.Location = new System.Drawing.Point(26, 381);
			this.btnCancelOrder.Name = "btnCancelOrder";
			this.btnCancelOrder.Size = new System.Drawing.Size(143, 23);
			this.btnCancelOrder.TabIndex = 4;
			this.btnCancelOrder.Text = "Cancel Order";
			this.btnCancelOrder.UseVisualStyleBackColor = true;
			// 
			// btnFillOrder
			// 
			this.btnFillOrder.Location = new System.Drawing.Point(179, 381);
			this.btnFillOrder.Name = "btnFillOrder";
			this.btnFillOrder.Size = new System.Drawing.Size(143, 23);
			this.btnFillOrder.TabIndex = 4;
			this.btnFillOrder.Text = "Fill Order";
			this.btnFillOrder.UseVisualStyleBackColor = true;
			// 
			// btnFinishUpdates
			// 
			this.btnFinishUpdates.Location = new System.Drawing.Point(626, 381);
			this.btnFinishUpdates.Name = "btnFinishUpdates";
			this.btnFinishUpdates.Size = new System.Drawing.Size(143, 23);
			this.btnFinishUpdates.TabIndex = 4;
			this.btnFinishUpdates.Text = "Finish";
			this.btnFinishUpdates.UseVisualStyleBackColor = true;
			// 
			// dgvCustomerOrders
			// 
			this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerOrders.Location = new System.Drawing.Point(26, 170);
			this.dgvCustomerOrders.Name = "dgvCustomerOrders";
			this.dgvCustomerOrders.ReadOnly = true;
			this.dgvCustomerOrders.RowHeadersVisible = false;
			this.dgvCustomerOrders.RowTemplate.Height = 25;
			this.dgvCustomerOrders.Size = new System.Drawing.Size(743, 182);
			this.dgvCustomerOrders.TabIndex = 5;
			// 
			// FillOrCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvCustomerOrders);
			this.Controls.Add(this.btnFinishUpdates);
			this.Controls.Add(this.btnFillOrder);
			this.Controls.Add(this.btnCancelOrder);
			this.Controls.Add(this.dtpFillDate);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.btnFindByOrderID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FillOrCancel";
			this.Text = "Fill or cancel an order";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Button btnFindByOrderID;
		private TextBox txtOrderID;
		private Label label2;
		private DateTimePicker dtpFillDate;
		private Button btnCancelOrder;
		private Button btnFillOrder;
		private Button btnFinishUpdates;
		private DataGridView dgvCustomerOrders;
	}
}