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

		private void Clear_outputLBLs()
		{
			LBL_output.Text = "";
			LBL_output2.Text = "";
			LBL_output3.Text = "";
			LBL_outputS.Text = "";
		}

		private void BT_length_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.String_length();
			LBL_output.Text = "lenght:" + System.Environment.NewLine
			+ stringSupport_inst.Output;
			stringSupport_inst.ClearOutputStrings();
		}

		private void BT_chars_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Length = stringSupport_inst.Input.Length;
			stringSupport_inst.OddOrEven();
			stringSupport_inst.String_toChar();
			LBL_output.Text = stringSupport_inst.Output;
			LBL_output2.Text = stringSupport_inst.Output2;
			LBL_output3.Text = stringSupport_inst.Output3;
			stringSupport_inst.ClearOutputStrings();
		}

		private void BT_delete_Click(object sender, EventArgs e)
		{
			//string input, output;
			Clear_outputLBLs();
			
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.FromPos = Convert.ToInt32(NUD_fromPos.Value);
			stringSupport_inst.Position = Convert.ToInt32(NUD_delete.Value);
			stringSupport_inst.Delete_String();
			
			LBL_output.Text += "output from deletion:\n" + stringSupport_inst.Output + "\n";
		}

		private void BT_insert_Click(object sender, EventArgs e)
		{
			//string input, insert, output;
			Clear_outputLBLs();
			
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Insert = TB_insert.Text;
			stringSupport_inst.Position = Convert.ToInt32(NUD_atPos.Value);
			stringSupport_inst.Insert_String();

			LBL_output.Text += "output from insertion:\n" + stringSupport_inst.Output + "\n";
		}
		
		private void BT_search1_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Search = TB_search.Text;
			stringSupport_inst.Search_1();
			LBL_output.Text = stringSupport_inst.Output;
		}
		
		private void BT_searchAll_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();

			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Search = TB_search.Text;
			stringSupport_inst.Search_All();

			LBL_output.Text = stringSupport_inst.Output;
		}
		
		private void BT_show_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.SubFromPos = Convert.ToInt32(NUD_subFromPos.Value);
			stringSupport_inst.Length = Convert.ToInt32(NUD_length.Value);
			stringSupport_inst.Show_String();
			LBL_output.Text += "output from show substring:\n" + stringSupport_inst.Output + "\n";
		}
		
		private void BT_split_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Split_String();
			LBL_output.Text = stringSupport_inst.Output;
		}

		private void BT_trim_Click(object sender, EventArgs e)
		{
			Clear_outputLBLs();
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Trim_String();
			LBL_output.Text = stringSupport_inst.Output;
		}
		
		private void NUD_fromPos_ValueChanged(object sender, EventArgs e)
		{
			NUD_delete.Maximum = TB_input.Text.Length - NUD_fromPos.Value;
		}

		private void NUD_length_ValueChanged(object sender, EventArgs e)
		{
			NUD_length.Maximum = TB_input.Text.Length - NUD_subFromPos.Value;
		}
		
		private void Strings_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void TB_input_TextChanged(object sender, EventArgs e)
		{
			if ((NUD_delete.Value != 0) && (NUD_atPos.Value != 0))
			{
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.Input_textChanged();
			NUD_delete.Maximum = stringSupport_inst.Length;
			NUD_fromPos.Maximum = stringSupport_inst.Length -1;
			}
			if ((NUD_subFromPos.Value != 0) && (NUD_length.Value != 0))
			{
			stringSupport_inst.Input_textChanged();
			stringSupport_inst.Input = TB_input.Text;
			NUD_length.Maximum = stringSupport_inst.Length;
			NUD_subFromPos.Maximum = stringSupport_inst.Length -1;
			}
			if (((NUD_delete.Value == 0) && (NUD_atPos.Value == 0)) &&
				((NUD_subFromPos.Value == 0) && (NUD_length.Value == 0)))
				LBL_output.Text = "output:" + System.Environment.NewLine;
				LBL_output2.Text = "" + System.Environment.NewLine;
				LBL_output3.Text = "" + System.Environment.NewLine;
		}

		private void TB_insert_TextChanged(object sender, EventArgs e)
		{
			NUD_atPos.Maximum = TB_input.Text.Length;
		}

		private void BT_formatNotifi_Click(object sender, EventArgs e)
		{
			stringSupport_inst.ClearOutputStrings();

			string[] cities = 
				{ "München", "Berlin", "Bonn", "Bremerhaven", "Ulm" };
			string format = "{0,-15}\t{1,9:0.0000}\t{2,12:#,####0.0}";
			LBL_outputS.Text = System.Environment.NewLine;
			
			for (int i = 0; i < cities.Length; i++)
			{
				stringSupport_inst.Output = String.Format(format, cities[i], i/7.0, i*10000/7);
				LSTB_output.Items.Add(stringSupport_inst.Output);
				LBL_outputS.Text += stringSupport_inst.Output + System.Environment.NewLine;
			}
		}
	}
}
