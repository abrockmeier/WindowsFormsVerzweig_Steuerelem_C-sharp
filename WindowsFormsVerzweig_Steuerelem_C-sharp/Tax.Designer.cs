namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class Tax
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
			this.BT_calc = new System.Windows.Forms.Button();
			this.LBL_salary = new System.Windows.Forms.Label();
			this.TB_salary = new System.Windows.Forms.TextBox();
			this.LBL_tax = new System.Windows.Forms.Label();
			this.LBL_TaxF = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BT_calc
			// 
			this.BT_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_calc.Location = new System.Drawing.Point(117, 197);
			this.BT_calc.Margin = new System.Windows.Forms.Padding(4);
			this.BT_calc.Name = "BT_calc";
			this.BT_calc.Size = new System.Drawing.Size(127, 41);
			this.BT_calc.TabIndex = 0;
			this.BT_calc.Text = "calculate";
			this.BT_calc.UseVisualStyleBackColor = true;
			this.BT_calc.Click += new System.EventHandler(this.BT_calc_Click);
			// 
			// LBL_salary
			// 
			this.LBL_salary.AutoSize = true;
			this.LBL_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_salary.Location = new System.Drawing.Point(113, 76);
			this.LBL_salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LBL_salary.Name = "LBL_salary";
			this.LBL_salary.Size = new System.Drawing.Size(59, 20);
			this.LBL_salary.TabIndex = 1;
			this.LBL_salary.Text = "salary:";
			// 
			// TB_salary
			// 
			this.TB_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_salary.Location = new System.Drawing.Point(117, 100);
			this.TB_salary.Margin = new System.Windows.Forms.Padding(4);
			this.TB_salary.Name = "TB_salary";
			this.TB_salary.Size = new System.Drawing.Size(375, 26);
			this.TB_salary.TabIndex = 0;
			// 
			// LBL_tax
			// 
			this.LBL_tax.AutoSize = true;
			this.LBL_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_tax.Location = new System.Drawing.Point(339, 202);
			this.LBL_tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LBL_tax.Name = "LBL_tax";
			this.LBL_tax.Size = new System.Drawing.Size(153, 29);
			this.LBL_tax.TabIndex = 3;
			this.LBL_tax.Text = "tax amount: 0";
			// 
			// LBL_TaxF
			// 
			this.LBL_TaxF.AutoSize = true;
			this.LBL_TaxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_TaxF.Location = new System.Drawing.Point(532, 96);
			this.LBL_TaxF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LBL_TaxF.Name = "LBL_TaxF";
			this.LBL_TaxF.Size = new System.Drawing.Size(168, 29);
			this.LBL_TaxF.TabIndex = 4;
			this.LBL_TaxF.Text = "tax factor: 12%";
			// 
			// Tax
			// 
			this.AcceptButton = this.BT_calc;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 308);
			this.Controls.Add(this.LBL_TaxF);
			this.Controls.Add(this.LBL_tax);
			this.Controls.Add(this.TB_salary);
			this.Controls.Add(this.LBL_salary);
			this.Controls.Add(this.BT_calc);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Tax";
			this.Text = "Tax";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tax_FormClosing);
			this.Load += new System.EventHandler(this.Tax_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BT_calc;
		private System.Windows.Forms.Label LBL_salary;
		private System.Windows.Forms.TextBox TB_salary;
		private System.Windows.Forms.Label LBL_tax;
		private System.Windows.Forms.Label LBL_TaxF;
	}
}