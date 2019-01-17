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

		private void Strings_Load(object sender, EventArgs e)
		{
			Select();
		}

		private void BT_length_Click(object sender, EventArgs e)
		{
			stringSupport_inst.Input = TB_input.Text;
			stringSupport_inst.String_length();
			LBL_output.Text = "label:" +System.Environment.NewLine + stringSupport_inst.Output;
		}

		private void BT_chars_Click(object sender, EventArgs e)
		{
			
		}
	}
}
