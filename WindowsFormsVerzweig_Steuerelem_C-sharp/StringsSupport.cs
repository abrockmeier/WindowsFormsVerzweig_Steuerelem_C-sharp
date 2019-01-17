using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	class StringsSupport
	{
		private string input;
		private string output;
		
		public string Input 
		{
			get	{ return input; }
			set { input = value; }
		}

		public string Output 
		{
			get	{ return output; }
			set { output = value; }
		}

		public void String_length()
		{
			output = Convert.ToString(input.Length);
		}

	}
}
