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
	public partial class RGBshift : Form
	{
		public RGBshift()
		{
			InitializeComponent();
			LBL_Output();
		}

		private void ShowColor()
		{
			P_canvas.BackColor = Color.FromArgb(Color_red, Color_green, Color_blue);
		}

		private void LBL_Output()
		{
			LBL_red.Text = "Rot\n" + TB_red.Value;
			LBL_green.Text = "Grün\n" + TB_green.Value;
			LBL_blue.Text = "Blue\n" + TB_blue.Value;
		}

		private void RGBshift_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void TB_red_ValueChanged(object sender, EventArgs e)
		{
			LBL_Output();
			Color_red = TB_red.Value;
			ShowColor();
		}

		private void TB_green_ValueChanged(object sender, EventArgs e)
		{
			LBL_Output();
			Color_green = TB_green.Value;
			ShowColor();
		}

		private void TB_blue_ValueChanged(object sender, EventArgs e)
		{
			LBL_Output();
			Color_blue = TB_blue.Value;
			ShowColor();
		}

		private void LBL_red_Click(object sender, EventArgs e)
		{
			//
		}

		private void LBL_green_Click(object sender, EventArgs e)
		{
			//
		}

		private void LBL_blue_Click(object sender, EventArgs e)
		{
			//
		}

		private void P_canvas_BackgroundImageChanged(object sender, EventArgs e)
		{
			 // hier besser nicht rein --- Schleife!?
		}
		public int Color_red { get { return color_red; } set { color_red = value;} }
		public int Color_green { get { return color_green; } set { color_green = value;} }
		public int Color_blue { get { return color_blue; } set { color_blue = value;} }
		
		private static	int color_red;
		private static	int color_green;
		private static	int color_blue;
	}
}
