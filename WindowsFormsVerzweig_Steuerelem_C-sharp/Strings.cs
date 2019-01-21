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
	public partial class Strings : Form
	{
		public Strings()
		{
			InitializeComponent();
		}

		StringsSupport stringSupport_inst = new StringsSupport();

		private void Strings_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}



		private void BT_length_Click(object sender, EventArgs e)
		{
			clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.String_length();
			LBL_output.Text = "lenght:" + System.Environment.NewLine
			+ stringSupport_inst.Output;
			stringSupport_inst.clearOutputStrings();


		}

		private void BT_chars_Click(object sender, EventArgs e)
		{
			clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Length = stringSupport_inst.Input.Length;
			stringSupport_inst.OddOrEven();
			stringSupport_inst.String_toChar();
			LBL_output.Text = stringSupport_inst.Output;
			LBL_output2.Text = stringSupport_inst.Output2;
			LBL_output3.Text = stringSupport_inst.Output3;
			stringSupport_inst.clearOutputStrings();

		}

		private void clear_outputLBLs()
		{
			LBL_output.Text = "";
			LBL_output2.Text = "";
			LBL_output3.Text = "";
		}

		private void BT_trim_Click(object sender, EventArgs e)
		{
			string input, trimmed, output;
			clear_outputLBLs();

			input = TB_input.Text;

			trimmed = input.Trim(' ', ';', '#');

			output = "trimmed: | " + trimmed + "|";
			LBL_output.Text = output;
		}

		private void BT_split_Click(object sender, EventArgs e)
		{
			string input = TB_input.Text;
			string[] splitString;
			clear_outputLBLs();

			splitString = input.Split(';');

			LBL_output.Text = "split result:" + "\n";

			for (int i = 0; i < splitString.Length; i++)
			{
				LBL_output.Text += "part: " + i + ":" + splitString[i] + "\n";
			}
		}

		private void BT_search1_Click(object sender, EventArgs e)
		{
			string input, search, output;
			int position;
			clear_outputLBLs();

			input = TB_input.Text;
			search = TB_search.Text;
			position = input.IndexOf(search);

			output = "search string at char: " + position;
			LBL_output.Text = output;
		}

		private void BT_searchAll_Click(object sender, EventArgs e)
		{
			string input, search, output;
			int position, startpos = 0, number = 0;
			clear_outputLBLs();

			input = TB_input.Text;
			search = TB_search.Text;

			if (input == "" && search == "")
				return;

			output = "search string at char: " + "\n";
			do
			{
				position = input.IndexOf(search, startpos);
				startpos = position + 1;
				if (position != -1)
				{
					output += position + "\n";
					number++;
				}
			}
			while (position != -1);
			{
				output += "Anzahl:" + number;
				LBL_output.Text = output;
			}
		}

		private void BT_insert_Click(object sender, EventArgs e)
		{
			string input, insert, output;
			clear_outputLBLs();
			
			input = TB_input.Text;
			insert = TB_insert.Text;

			output = input.Insert((int)NUD_atPos.Value, insert);
			LBL_output.Text = output;
		}

		private void TB_insert_TextChanged(object sender, EventArgs e)
		{
			string input;
			input = TB_input.Text;
			NUD_atPos.Maximum = input.Length;
		}

		private void BT_delete_Click(object sender, EventArgs e)
		{
			string input, output;
			clear_outputLBLs();
			
			input = TB_input.Text;
			output = input.Remove((int)NUD_fromPos.Value,
				(int)NUD_delete.Value);
				LBL_output.Text = output;
		}

		private void BT_show_Click(object sender, EventArgs e)
		{
			string input, output;
			clear_outputLBLs();
			
			input = TB_input.Text;
			output = input.Substring((int)NUD_subFromPos.Value,
				(int) NUD_length.Value);
			LBL_output.Text = output;
		}

		private void TB_input_TextChanged(object sender, EventArgs e)
		{
			if ((NUD_delete.Value != 0) && (NUD_atPos.Value != 0))
			{
			string input = TB_input.Text;
			NUD_delete.Maximum = input.Length;
			NUD_fromPos.Maximum = input.Length -1;
			}
			if ((NUD_subFromPos.Value != 0) && (NUD_length.Value != 0))
			{
			string input = TB_input.Text;
			NUD_subFromPos.Maximum = input.Length -1;
			NUD_length.Maximum = input.Length;
			}
			if (((NUD_delete.Value == 0) && (NUD_atPos.Value == 0)) &&
				((NUD_subFromPos.Value == 0) && (NUD_length.Value == 0)))
				LBL_output.Text = "output:" + System.Environment.NewLine;
				
		}

		private void NUD_fromPos_ValueChanged(object sender, EventArgs e)
		{
			string input = TB_input.Text;
			NUD_delete.Maximum = input.Length - NUD_fromPos.Value;
		}

		private void NUD_length_ValueChanged(object sender, EventArgs e)
		{
			string input = TB_input.Text;
			NUD_length.Maximum = input.Length - NUD_subFromPos.Value;
		}
	}
}
