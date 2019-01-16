using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	class TaxSupport : Tax
	{
		private int taxAmount, validNum; 
		private bool salaryValid = true;
		private string salary;

		public int TaxAmount
		{
			get { return taxAmount; }
			set { taxAmount = value; }
		}
		public bool SalaryValid // Not necessary
		{ 
			get { return salaryValid; }
			set { salaryValid = value; } 
		}
		public string Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		private string[,] ErrorBox()
		{
			SalaryValid = false;
			Salary = "0";
			string[,] errorArray = new string[3,2];
			string message = "Please enter a valid number (-1 < X < 2147483646)  !";
			string caption	= "Error Detected in Input";
			errorArray[0,0] = "message";
			errorArray[1,0] = "caption";
			errorArray[2,0] = "salary";
			errorArray[0,1] = message;
			errorArray[1,1] = caption;
			errorArray[2,1] = salary;
			//DialogResult error;
			return errorArray;
		}

		internal static bool ValidateSalary()
		{	
			
			if ((Convert.ToInt32(TB_salary.Text) > 2147483647) ||
				(Convert.ToInt32(TB_salary.Text) < 0))
			{
				return = false;
				ErrorBox();
			}
			else return = true;
		}

		private void CalcTax()
		{
			TaxAmount = validNum * 12 / 100;
		}


	}
}


//private void ErrorBox()
		//{
		//	SalaryValid = false;
		//	TB_salary.Text = "0";
		//	string message = "Please enter a valid number (-1 < X < 2147483646)  !";
		//	string caption	= "Error Detected in Input";
		//	DialogResult error;
		//	error = MessageBox.Show(message, caption);
		//}
		
		//internal void ValidateSalary()
		//{	
			
		//	if ((Convert.ToInt32(TB_salary.Text) > 2147483647) ||
		//		(Convert.ToInt32(TB_salary.Text) < 0))
		//	{
		//		SalaryValid = false;
		//		ErrorBox();
		//	}
		//	else SalaryValid = true;
		//}