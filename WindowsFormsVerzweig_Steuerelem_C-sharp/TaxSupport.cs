using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	class TaxSupport
	{
		private int taxAmount, iSalary; 
		private bool salaryValid = true;
		private string salary, salary_SV;
		private int factor;

		public int Factor
		{
			get { return factor; }
			set { factor = value; }
		}
		public int TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = value; }
		}
		public bool SalaryValid 
		{ 
			get { return salaryValid; }
			set { salaryValid = value; } 
		}
		public string Salary
		{
			get { return salary; }
			set { salary = value; }
		}
		public string Salary_SV
		{ 
			get { return salary_SV; }
			set { salary_SV = value; }
		}

		internal string ValidateSalary()
		{	
			if (int.TryParse(Salary, out iSalary))
			{
				if(iSalary < 0)
				Salary = Convert.ToString(iSalary);
				return Salary;
			}
			else return "please enter a pos. number < 2.147.483.647!";
		}

		internal void CalcTax()
		{
			TaxAmount =  Convert.ToInt32(Salary) / 100 * Factor;
		}

		internal int TaxFactor()
		{
			if (iSalary >= 0)
				Factor = 12;
			if (iSalary > 12000)
				Factor = 15;
			if (iSalary > 20000)
				Factor = 20;
			if (iSalary > 30000)
				Factor = 25;
			return Factor;
		}
	}
}
