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
		TaxSupport taxSupport_inst = new TaxSupport();

		//	Vars und methoden in extra klasse, beim laden der form objekt 
		//	erstellen und mit mit der objektinstanz zugreifen..

		private void BT_calc_Click(object sender,EventArgs e)
		{	
			taxSupport_inst.Salary = TB_salary.Text;
			taxSupport_inst.Salary_SV = taxSupport_inst.ValidateSalary();
			if (taxSupport_inst.Salary_SV == taxSupport_inst.Salary)
			{
				taxSupport_inst.TaxFactor();
				taxSupport_inst.CalcTax();
				LBL_tax.Text = "tax amount: " + taxSupport_inst.TaxAmount;
				LBL_TaxF.Text = "tax factor: " + taxSupport_inst.Factor +" %" ;
			}
			else
			{
				TB_salary.Text = taxSupport_inst.Salary_SV;
			}
		}

		private void Tax_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void Tax_Load(object sender, EventArgs e)
		{
			Select();
		}
	}
}
