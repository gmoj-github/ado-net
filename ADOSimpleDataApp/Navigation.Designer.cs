namespace ADOSimpleDataApp
{
	partial class Navigation
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
			this.btnGoToAdd = new System.Windows.Forms.Button();
			this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGoToAdd
			// 
			this.btnGoToAdd.Location = new System.Drawing.Point(100, 142);
			this.btnGoToAdd.Name = "btnGoToAdd";
			this.btnGoToAdd.Size = new System.Drawing.Size(157, 23);
			this.btnGoToAdd.TabIndex = 1;
			this.btnGoToAdd.Text = "Add an account";
			this.btnGoToAdd.UseVisualStyleBackColor = true;
			this.btnGoToAdd.Click += new System.EventHandler(this.btnGoToAdd_Click);
			// 
			// btnGoToFillOrCancel
			// 
			this.btnGoToFillOrCancel.Location = new System.Drawing.Point(100, 189);
			this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
			this.btnGoToFillOrCancel.Size = new System.Drawing.Size(157, 23);
			this.btnGoToFillOrCancel.TabIndex = 1;
			this.btnGoToFillOrCancel.Text = "Fill or cancel an order";
			this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
			this.btnGoToFillOrCancel.Click += new System.EventHandler(this.btnGoToFillOrCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(610, 397);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(157, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "What do you want to do?";
			// 
			// Navigation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGoToFillOrCancel);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGoToAdd);
			this.Name = "Navigation";
			this.Text = "Welcome";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Button btnGoToAdd;
		private Button btnGoToFillOrCancel;
		private Button btnExit;
		private Label label1;
	}
}