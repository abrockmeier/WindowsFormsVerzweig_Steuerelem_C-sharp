using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	public partial class Files : Form
	{
		public Files()
		{
			InitializeComponent();
		}

		private void BT_read_Click(object sender, EventArgs e)
		{
			FileStream fsI = new FileStream("ein.txt", FileMode.Open);
			StreamReader sr = new StreamReader(fsI);
			string zeile;
			LBL_output.Text += System.Environment.NewLine;
			while (sr.Peek() != -1)
			{
				zeile = sr.ReadLine();
				LBL_output.Text += zeile + System.Environment.NewLine;
 			}
			sr.Close();
		}

		private void BT_write_Click(object sender, EventArgs e)
		{
			FileStream fsO = new FileStream("aus.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fsO);
			sw.WriteLine(TB_input.Text);
			sw.Close();
		}

		private void Files_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void BT_fileExists_Click(object sender, EventArgs e)
		{
			FileStream fs_E;
			StreamReader sr;
			string filename = "ein.txt";
			string zeile;
			if (!File.Exists(filename))
			{
				MessageBox.Show("Datei " + filename + " existiert nicht");
				return;
			}
			fs_E = new FileStream(filename, FileMode.Open);
			sr = new StreamReader(fs_E);
			while (sr.Peek() != -1)
			{
				zeile = sr.ReadLine();
				LBL_output.Text += zeile + "\n";
			}
			sr.Close();
		}

		private void BT_exception_Click(object sender, EventArgs e)
		{
			FileStream fs;
			StreamReader sr;
			string line;

			try
			{
				fs = new FileStream("ein2.txt", FileMode.Open);
				sr = new StreamReader(fs);
				while (sr.Peek() != -1)
				{
					line = sr.ReadLine();
					LBL_output.Text += line + "\n";
				}
				sr.Close();
			}
			catch (Exception ex)
			{
			MessageBox.Show(ex.Message);
			}
			}

		private void BT_Path_Click(object sender, EventArgs e)
		{
			Form pBox = new paths();
			InitializeComponent();
			pBox.Owner = this;
			this.Hide();
			pBox.Show();
		}
	}
	}

