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
	public partial class CheckBox : Form
	{
		public CheckBox()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (CB_CheckBox.Checked)
				LBL_two.Text = "ON";
			else
				LBL_two.Text = "OFF";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (CB_CheckBox.Checked)
				LBL_one.Text = "ON";
			else
				LBL_one.Text = "OFF";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CB_CheckBox.Checked = !CB_CheckBox.Checked;
		}

		private void CheckBox_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.selector = 0;
			this.Owner.Show();
			this.Hide();
		}
	}
}
