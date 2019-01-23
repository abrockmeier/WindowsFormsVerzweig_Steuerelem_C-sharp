using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	class StringsSupport
	{
		private int count = 0;
		private int even, fromPos, length, odd, position;
		private int startpos = 0;
		private int subFromPos;
		private string input, insert, output, output2, output3, trimmed;
		//private string[] cities;
		private string[] splitString;
		private string search;
		//private string formatS;

		public int Count
		{
			get { return count; }
			set { count = value; }
		}
		public int Even
		{
			get { return even; }
			set { even = value; }
		}
		public int FromPos
		{
			get { return fromPos; }
			set { fromPos = value; }
		}
		public int Length
		{
			get { return length; }
			set { length = value; }
		}
		public int Odd
		{
			get { return odd; }
			set { odd = value; }
		}
		public int Position
		{
			get { return position; }
			set { position = value; }
		}
		public int Startpos
		{
			get { return startpos; }
			set { startpos = value; }
		}
		public int SubFromPos
		{
			get { return subFromPos; }
			set { subFromPos = value; }
		}
		/*public string FormatS
		{
			get { return formatS; }
			set { formatS = value; }
		}*/
		public string Input 
		{
			get	{ return input; }
			set { input = value; }
		}
		public string Insert
		{
			get { return insert; }
			set { insert = value; }
		}
		public string Output 
		{
			get	{ return output; }
			set { output = value; }
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
		public string Trimmed
		{
			get { return trimmed; }
			set { trimmed = value; }
		}
		/*public string[] Cities
		{
			get { return cities; }
			set { cities = value; }
		}*/
		public string[] SplitString
		{
			get { return splitString; }
			set { splitString = value; }
		}
		public string Search
		{
			get { return search; }
			set { search = value; }
		}

		
		
		public void ClearOutputStrings()
		{
			Output = "";
			Output2 = "";
			Output3 = "";
		}
		
		public void Delete_String()
		{
			Output = Input.Remove((int)FromPos,	(int)Position);
		}
		
		public void Input_textChanged()
		{
			String_length();
			Length = Input.Length;
		}
		
		public void Insert_String()
		{
			Output = input.Insert((int)Position, insert);
		}

		public void OddOrEven()
		{
			if (Length % 2 == 0)
			{
				Even = 1;
				Odd = 0;
			}
			else
			{
				Odd = 1;
				Even = 0;
			}

		}
		
		public void Search_1()
		{
			Position = Input.IndexOf(Search);

			if (!(Position == -1))
			{
				Output = "search string at char: " + position;
			}
			else
				Output = "unable to find search string!";
		}

		public void Search_All()
		{
			if (Input == "" && Search == "")
				return;

			Output = "search string at char: " + "\n";
			do
			{
				Position = Input.IndexOf(Search, Startpos);
				Startpos = Position + 1;
				if (Position != -1)
				{
					Output += Position + "\n";
					Count++;
				}
			}
			while (Position != -1);
			{
				Output += "Anzahl:" + Count;
			}
		}

		public void Show_String()
		{
			Output = Input.Substring((int)SubFromPos, (int) Length);
		}

		public void Split_String()
		{
			SplitString = Input.Split(';');
			Output = "split result:" + "\n";
			for (int i = 0; i < SplitString.Length; i++)
			{
				Output += "part " + i + ":" + splitString[i] + "\n";
			}
		}

		public void String_length()
		{
			Output = Convert.ToString(Input.Length);
		}

		public void String_toChar()
		{
			Output = "output:" + System.Environment.NewLine;
			if (Length >= 100)
			{
				Output = "You have crossed the Number of 90 entered chars! xD";
			}
			else if (Length <= 35)
			{
				foreach (char c in Input)
				{
					Output += (c + System.Environment.NewLine);
				}
			}
			else if (Length < 65)
			{
				for (int i = 0; i < (Length / 2 + Odd) ; i++)
				{
					Output += (Input[i] + System.Environment.NewLine);
				}

				for (int i = (Length - Length/2); i < Length ; i++)
				{
					Output2 += (Input[i] + System.Environment.NewLine);
				}
				
			}
			else if (Length < 100)
			{
				for (int i = 0; i < (Length / 3  + Odd); i++)
				{
					Output += (Input[i] + System.Environment.NewLine);
				}
				for (int j = Length / 3+Odd; j < (Length / 3+ Odd) * 2; j++)
				{
					Output2 += (Input[j] + System.Environment.NewLine);
				}
				for (int k = Length / 3 * 2 +2*Odd; k  < length ; k++)
				{
					Output3 += (Input[k] + System.Environment.NewLine);
				}
			}	
		}
			
		public void Trim_String()
		{
			Trimmed = Input.Trim(' ', ';', '#');
			Output = "trimmed: | " + Trimmed + "|";
		}
	}
}
