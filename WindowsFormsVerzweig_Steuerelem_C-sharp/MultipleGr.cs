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
	public partial class MultipleGr : Form
	{
		public MultipleGr()
		{
			InitializeComponent();
		}

		private string OutCity = "City";
		private string OutBillet = "Billet";

		private void RB_CheckedChangeBillet(object sender, EventArgs e)
		{
			if (RB_Appartment.Checked)
				OutBillet = "Appartment";
			else if (RB_Pension.Checked)
				OutBillet = "Pension";
			else
				OutBillet = "Hotel";
			
			LBLCity_Billet.Text = OutCity + ", " + OutBillet;
		}

		private void RB_CheckedChangeCity(object sender, EventArgs e)
		{
			if (RB_Berlin.Checked)
				OutCity = "Berlin";
			else if (RB_Paris.Checked)
				OutCity = "Paris";
			else
				OutCity = "Rom";

			LBLCity_Billet.Text = OutCity + ", " + OutBillet;
		}

		private void MultipleGr_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}
	}
}
