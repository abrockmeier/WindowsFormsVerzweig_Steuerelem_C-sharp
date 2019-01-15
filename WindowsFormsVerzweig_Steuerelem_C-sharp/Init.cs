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
	public partial class Init : Form
	{
		

		public Init()
		{
			InitializeComponent();
		}

		private void LLBL_CheckBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form cBox = new CheckBox();
			InitializeComponent();
			cBox.Owner = this;
			this.Hide();
			cBox.Show();
		}

		private void LLBL_Options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form oBox = new Options();
			InitializeComponent();
			oBox.Owner = this;
			this.Hide();
			oBox.Show();
		}

		private void LLBL_Future_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form mBox = new MultipleGr();
			InitializeComponent();
			mBox.Owner = this;
			this.Hide();
			mBox.Show();
		}

		private void LLBL_RGBshiftClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form rBox = new RGBshift();
			InitializeComponent();
			rBox.Owner = this;
			this.Hide();
			rBox.Show();
		}

		private void LL_Tax_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form tBox = new Tax();
			InitializeComponent();
			tBox.Owner = this;
			this.Hide();
			tBox.Show();
		}
	}
}
