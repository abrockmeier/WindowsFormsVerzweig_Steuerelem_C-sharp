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
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
			
		}

		//
		private void BT_check_Click(object sender, EventArgs e)
		{
			if (RB_red.Checked)
			{
				LBL_top.Text = "checked!";
				LBL_top.BackColor = Color.PaleVioletRed;
			}
			else if (RB_green.Checked)
			{
				LBL_top.Text = "checked!";
				LBL_top.BackColor = Color.Honeydew;
			}
			else
			{
				LBL_top.Text = "checked!";
				LBL_top.BackColor = Color.Teal;
			}
		}

		private void BT_switchC_Click(object sender, EventArgs e)
		{
			if (RB_red.Checked)
			{
				LBL_bottom.ForeColor = Color.Red;
				if (RB_red.Checked && LBL_bottom.BackColor == Color.Red)
				{
					LBL_bottom.ForeColor = Color.White;
					LBL_bottom.BackColor = LBL_top.BackColor;
				}
			}
			else if (RB_green.Checked)
			{
				LBL_bottom.ForeColor = Color.Green;
				if (RB_red.Checked && LBL_bottom.BackColor == Color.Green)
				{
					LBL_bottom.ForeColor = Color.White;
					LBL_bottom.BackColor = LBL_top.BackColor;
				}
			}
			else
			{
				LBL_bottom.ForeColor = Color.Blue;
				if (RB_red.Checked && LBL_bottom.BackColor == Color.Blue)
				{
					LBL_bottom.ForeColor = Color.White;
					LBL_bottom.BackColor = LBL_top.BackColor;
				}
			}
		}

		private void RB_red_CheckedChanged(object sender, EventArgs e)
		{
			if (RB_red.Checked)
			{
				LBL_bottom.Text = "Red";
				LBL_bottom.ForeColor = Color.Black;
			}
		}

		private void RB_green_CheckedChanged(object sender, EventArgs e)
		{
			if (RB_red.Checked)
			{
				LBL_bottom.Text = "Green";
				LBL_bottom.ForeColor = Color.Black;
			}
		}

		private void RB_blue_CheckedChanged(object sender, EventArgs e)
		{
			if (RB_blue.Checked)
			{
				LBL_bottom.Text = "Blue";
				LBL_bottom.ForeColor = Color.Black;
			}
		}

		private void Options_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void RB_color_changed(object sender, EventArgs e)
		{
		if (RB_red.Checked)
			LBL_top.ForeColor = Color.Red;
		else if (RB_blue.Checked)
			LBL_top.ForeColor = Color.Blue;
		else 
			LBL_top.ForeColor = Color.Green;
		}
	}
}
