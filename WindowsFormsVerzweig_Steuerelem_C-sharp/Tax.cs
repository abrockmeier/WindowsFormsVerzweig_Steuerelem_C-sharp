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
			TaxSupport taxSupport_inst = new TaxSupport();
		}
		//	Vars und methoden in extra klasse, beim laden der form objekt 
		//	erstellen und mit mit der objektinstanz zugreifen..
		
		//private int taxAmount, validNum; 
		//private bool salaryValid = true;

		//public int TaxAmount
		//{
		//	get { return taxAmount; }
		//	set { taxAmount = value; }
		//}
		//public bool SalaryValid // Not necessary
		//{ 
		//	get { return salaryValid; }
		//	set { salaryValid = value; } 
		//}

		private void BT_calc_Click(object sender,EventArgs e)
		{	
			//	Aufruf der Methode in Tax-Support---?
			;
			if (TaxSupport.ValidateSalary())
			{
				CalcTax();
				LBL_tax.Text = "tax amount: " + TaxAmount; // "this." is necessary.. why! 
			}
		}


		private void TB_salary_Validating(object sender,EventArgs e)
		{
			if (int.TryParse(TB_salary.Text, out validNum))
			ValidateSalary();
			else ErrorBox();
		}

		private void Tax_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		

		private void CalcTax()
		{
			TaxSupport.TaxAmount = validNum * 12 / 100;
		}

		private void Tax_Load(object sender, EventArgs e)
		{
			Select();
		}
	}
}
