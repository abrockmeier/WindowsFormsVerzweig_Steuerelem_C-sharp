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
		private string output2;
		private string output3;
		private int length;
		private int even;
		private int odd;


		public int Odd
		{
			get { return odd; }
			set { odd = value; }
		}

		public int	Even
		{
			get { return even; }
			set { even = value; }
		}

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


		public int Length
		{
			get { return length; }
			set { length = value; }
		}

		public string Output2
		{
			get { return output2; }
			set { output2 = value; }
		}
		public string Output3
		{
			get { return output3; }
			set { output3 = value; }
		}

		public void String_length()
		{
			Output = Convert.ToString(Input.Length);
		}

			
		public void String_toChar()
		{
			Output = "output:" + System.Environment.NewLine;
			if (Length >= 75)
			{
				Output = "You have crossed the Number of 75 entered chars! xD";
				if ((Length > 51)&&(Length<75))
				{
					for (int i = 0; i + Odd  < (Length / 3) ; i++)
					{
						Output += (Input[i] + System.Environment.NewLine);
					}

					for (int i = (Length - Length/3); i <= Length/3*2; i++)
					{
						Output2 += (Input[i] + System.Environment.NewLine);
					}
					for (int i =  Length/3*2 ; i < length - Even; i++)
					{
						Output3 += (Input[i] + System.Environment.NewLine);
					
					}
				
				if ((Length > 25)&&(Length <=50))
				{
					for (int i = 0; i < (Length / 2 + Odd) ; i++)
					{
						Output += (Input[i] + System.Environment.NewLine);
					}

					for (int i = (Length - Length/2); i <= Length - Even; i++)
					{
						Output2 += (Input[i] + System.Environment.NewLine);
					}
				
				}
				}
			}
			else 
			{
				foreach (char c in Input)
				{
					Output += (c + System.Environment.NewLine);
				}
			}
			 
		}
			public void OddOrEven()
			{
			if (Length % 2 == 0)
				Even = 1;
			else Odd = 1;
			}

	}
}
		/* old version with string builder but only one Label,...
		public void String_toChar()
		{
			Output = "label:" + System.Environment.NewLine;
			foreach (char c in Input)
			{
				if (Length <= 25)
					Output += (c + System.Environment.NewLine);
				if (Length > 25)
				{
					
					for (int i = Length; i % 2 != 0; i--)
					{
						sb.Append(c + "");
					}
					for (int i = Length; i % 2 == 0; i--)
					{
						sb.Append(c);
						sb.Append(System.Environment.NewLine);
					}
					
				}
				else
				{
					Output = "Please feed me with less Input!";
					break;
				}
			}
			Output += sb;
			Input = "";
		} 
		*/
