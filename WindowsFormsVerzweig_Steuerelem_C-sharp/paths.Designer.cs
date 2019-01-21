namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class paths
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BT_fileList = new System.Windows.Forms.Button();
			this.BT_sysEntries = new System.Windows.Forms.Button();
			this.BT_inDirectory = new System.Windows.Forms.Button();
			this.BT_moveUp = new System.Windows.Forms.Button();
			this.LBL_path = new System.Windows.Forms.Label();
			this.LBL_details = new System.Windows.Forms.Label();
			this.LSTB_pathFiles = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// BT_fileList
			// 
			this.BT_fileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_fileList.Location = new System.Drawing.Point(80, 57);
			this.BT_fileList.Name = "BT_fileList";
			this.BT_fileList.Size = new System.Drawing.Size(100, 30);
			this.BT_fileList.TabIndex = 0;
			this.BT_fileList.Text = "file list";
			this.BT_fileList.UseVisualStyleBackColor = true;
			this.BT_fileList.Click += new System.EventHandler(this.BT_fileList_Click);
			// 
			// BT_sysEntries
			// 
			this.BT_sysEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_sysEntries.Location = new System.Drawing.Point(260, 57);
			this.BT_sysEntries.Name = "BT_sysEntries";
			this.BT_sysEntries.Size = new System.Drawing.Size(100, 30);
			this.BT_sysEntries.TabIndex = 1;
			this.BT_sysEntries.Text = "system entries";
			this.BT_sysEntries.UseVisualStyleBackColor = true;
			this.BT_sysEntries.Click += new System.EventHandler(this.BT_sysEntries_Click);
			// 
			// BT_inDirectory
			// 
			this.BT_inDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_inDirectory.Location = new System.Drawing.Point(440, 57);
			this.BT_inDirectory.Name = "BT_inDirectory";
			this.BT_inDirectory.Size = new System.Drawing.Size(100, 30);
			this.BT_inDirectory.TabIndex = 2;
			this.BT_inDirectory.Text = "in directory";
			this.BT_inDirectory.UseVisualStyleBackColor = true;
			this.BT_inDirectory.Click += new System.EventHandler(this.BT_inDirectory_Click);
			// 
			// BT_moveUp
			// 
			this.BT_moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_moveUp.Location = new System.Drawing.Point(620, 57);
			this.BT_moveUp.Name = "BT_moveUp";
			this.BT_moveUp.Size = new System.Drawing.Size(100, 30);
			this.BT_moveUp.TabIndex = 3;
			this.BT_moveUp.Text = "move up";
			this.BT_moveUp.UseVisualStyleBackColor = true;
			this.BT_moveUp.Click += new System.EventHandler(this.BT_moveUp_Click);
			// 
			// LBL_path
			// 
			this.LBL_path.AutoSize = true;
			this.LBL_path.Location = new System.Drawing.Point(77, 125);
			this.LBL_path.Name = "LBL_path";
			this.LBL_path.Size = new System.Drawing.Size(40, 17);
			this.LBL_path.TabIndex = 4;
			this.LBL_path.Text = "path:";
			// 
			// LBL_details
			// 
			this.LBL_details.AutoSize = true;
			this.LBL_details.Location = new System.Drawing.Point(77, 452);
			this.LBL_details.Name = "LBL_details";
			this.LBL_details.Size = new System.Drawing.Size(53, 17);
			this.LBL_details.TabIndex = 7;
			this.LBL_details.Text = "details:";
			// 
			// LSTB_pathFiles
			// 
			this.LSTB_pathFiles.FormattingEnabled = true;
			this.LSTB_pathFiles.ItemHeight = 16;
			this.LSTB_pathFiles.Location = new System.Drawing.Point(80, 161);
			this.LSTB_pathFiles.Name = "LSTB_pathFiles";
			this.LSTB_pathFiles.Size = new System.Drawing.Size(667, 276);
			this.LSTB_pathFiles.TabIndex = 8;
			this.LSTB_pathFiles.SelectedIndexChanged += new System.EventHandler(this.LSTB_pathFiles_SelectedIndexChanged);
			// 
			// paths
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 703);
			this.Controls.Add(this.LSTB_pathFiles);
			this.Controls.Add(this.LBL_details);
			this.Controls.Add(this.LBL_path);
			this.Controls.Add(this.BT_moveUp);
			this.Controls.Add(this.BT_inDirectory);
			this.Controls.Add(this.BT_sysEntries);
			this.Controls.Add(this.BT_fileList);
			this.Name = "paths";
			this.Text = "paths";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.paths_FormClosing);
			this.Load += new System.EventHandler(this.paths_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BT_fileList;
		private System.Windows.Forms.Button BT_sysEntries;
		private System.Windows.Forms.Button BT_inDirectory;
		private System.Windows.Forms.Button BT_moveUp;
		private System.Windows.Forms.Label LBL_path;
		private System.Windows.Forms.Label LBL_details;
		private System.Windows.Forms.ListBox LSTB_pathFiles;
	}
}