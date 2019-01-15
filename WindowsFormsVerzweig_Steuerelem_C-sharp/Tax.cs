using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	public partial class Tax : Form
	{
		public Tax()
		{
			InitializeComponent();
			TB_salary.Text = "0";
		}
		private int taxAmount, validNum; 
		private bool salaryValid = true;

		public int TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = TaxAmount; }
		}
		public bool SalaryValid // Not necessary
		{ 
			get { return salaryValid; }
			set { salaryValid = SalaryValid; } 
		}

		private void BT_calc_Click(object sender, EventArgs e)
		{
			ValidateSalary();
			if (SalaryValid)
			{
				CalcTax(sender,e);
				LBL_tax.Text = "tax amount: " + this.TaxAmount; // "this." is necessary.. why! 
				
			}
		}

		private void Tax_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void TB_salary_Validating(object sender, CancelEventArgs e)
		{
			if (int.TryParse(TB_salary.Text, out validNum))
			ValidateSalary();
			else ErrorBox();
		}

		private void ErrorBox()
		{
			SalaryValid = false;
			TB_salary.Text = "0";
			string message = "Please enter a valid number (-1 < X < 2147483646)  !";
			string caption	= "Error Detected in Input";
			DialogResult error;
			error = MessageBox.Show(message, caption);
		}
		
		internal void ValidateSalary()
		{	
			
			if ((Convert.ToInt32(TB_salary.Text) > 2147483647) ||
				(Convert.ToInt32(TB_salary.Text) < 0))
			{
				SalaryValid = false;
				ErrorBox();
			}
			else SalaryValid = true;
		}

		private void CalcTax(object sender, EventArgs e)
		{
			taxAmount = validNum * 12 / 100; 
			// Frage @herr hübsch: warum funktioniert hier der Setter nicht?
			// TaxAmount = validNum * 12 / 100;
		}

		private void Tax_Load(object sender, EventArgs e)
		{
			Select();
		}
	}
}
