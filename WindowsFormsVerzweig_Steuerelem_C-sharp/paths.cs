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
	public partial class paths : Form
	{
		public paths()
		{
			InitializeComponent();
		}

		private void paths_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void paths_Load(object sender, EventArgs e)
		{
			if (Directory.Exists(@"C:\temp"))
				Directory.SetCurrentDirectory(@"C:\temp");
			else
				MessageBox.Show(@"Verzeichnis C:\temp existiert nicht!");
			LBL_path.Text = Directory.GetCurrentDirectory();
		}

		private void BT_fileList_Click(object sender, EventArgs e)
		{
			string current_directory;
			string [] current_filelist;

			current_directory = Directory.GetCurrentDirectory();
			current_filelist = Directory.GetFiles(current_directory);
			LSTB_pathFiles.Items.Clear();
			foreach (string s in current_filelist)
			LSTB_pathFiles.Items.Add(s);
		}

		private void BT_sysEntries_Click(object sender, EventArgs e)
		{
			systementries();
		}

		private void systementries()
		{
			string current_directory;
			string[] current_filelist;

			current_directory = Directory.GetCurrentDirectory();
			current_filelist = Directory.GetFileSystemEntries(current_directory);
			LSTB_pathFiles.Items.Clear();
			foreach (string s in current_filelist)
			LSTB_pathFiles.Items.Add(s);
		}

		private void LSTB_pathFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name;
			if (LSTB_pathFiles.SelectedIndex != -1)
			{
				name = LSTB_pathFiles.Text;
				LBL_details.Text = name + "\ncreated:" + 
				File.GetCreationTime(name) + "\nlast access: " +
				File.GetLastAccessTime(name) + "\n" + "last " + "write access:" +
				File.GetLastWriteTime(name);
				}
			else
				MessageBox.Show("No entry selected!");
		}

		private void BT_inDirectory_Click(object sender, EventArgs e)
		{
			if (LSTB_pathFiles.SelectedIndex != -1)
			{
				try
				{
					Directory.SetCurrentDirectory(LSTB_pathFiles.Text);
				}
				catch
				{
					MessageBox.Show(LSTB_pathFiles.Text + "is not a directory!");
				}
			}
			else
				MessageBox.Show("No entry selected");
			LBL_path.Text = Directory.GetCurrentDirectory();
			systementries();
		}

		private void BT_moveUp_Click(object sender, EventArgs e)
		{
			Directory.SetCurrentDirectory("..");
			LBL_path.Text = Directory.GetCurrentDirectory();
			systementries();
		}
	}
}
