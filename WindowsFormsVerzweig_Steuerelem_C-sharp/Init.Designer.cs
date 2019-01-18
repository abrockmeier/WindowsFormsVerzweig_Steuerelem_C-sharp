namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class Init
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
			this.LLBL_CheckBox = new System.Windows.Forms.LinkLabel();
			this.LLBL_Options = new System.Windows.Forms.LinkLabel();
			this.LBL_PCAF = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LBL_DateTimes = new System.Windows.Forms.LinkLabel();
			this.LL_strings = new System.Windows.Forms.LinkLabel();
			this.LL_Tax = new System.Windows.Forms.LinkLabel();
			this.LL_RGBshift = new System.Windows.Forms.LinkLabel();
			this.LLBL_Future = new System.Windows.Forms.LinkLabel();
			this.LLB_fileIO = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LLBL_CheckBox
			// 
			this.LLBL_CheckBox.AutoSize = true;
			this.LLBL_CheckBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LLBL_CheckBox.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LLBL_CheckBox.Location = new System.Drawing.Point(17, 70);
			this.LLBL_CheckBox.Name = "LLBL_CheckBox";
			this.LLBL_CheckBox.Size = new System.Drawing.Size(210, 32);
			this.LLBL_CheckBox.TabIndex = 0;
			this.LLBL_CheckBox.TabStop = true;
			this.LLBL_CheckBox.Text = "CheckBox-form";
			this.LLBL_CheckBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLBL_CheckBox_LinkClicked);
			// 
			// LLBL_Options
			// 
			this.LLBL_Options.AutoSize = true;
			this.LLBL_Options.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LLBL_Options.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LLBL_Options.Location = new System.Drawing.Point(19, 112);
			this.LLBL_Options.Name = "LLBL_Options";
			this.LLBL_Options.Size = new System.Drawing.Size(195, 32);
			this.LLBL_Options.TabIndex = 1;
			this.LLBL_Options.TabStop = true;
			this.LLBL_Options.Text = "Options-form";
			this.LLBL_Options.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLBL_Options_LinkClicked);
			// 
			// LBL_PCAF
			// 
			this.LBL_PCAF.AutoSize = true;
			this.LBL_PCAF.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_PCAF.Location = new System.Drawing.Point(19, 18);
			this.LBL_PCAF.Name = "LBL_PCAF";
			this.LBL_PCAF.Size = new System.Drawing.Size(351, 36);
			this.LBL_PCAF.TabIndex = 2;
			this.LBL_PCAF.Text = "Please choose a form:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LLB_fileIO);
			this.panel1.Controls.Add(this.LBL_DateTimes);
			this.panel1.Controls.Add(this.LL_strings);
			this.panel1.Controls.Add(this.LL_Tax);
			this.panel1.Controls.Add(this.LL_RGBshift);
			this.panel1.Controls.Add(this.LLBL_Future);
			this.panel1.Controls.Add(this.LBL_PCAF);
			this.panel1.Controls.Add(this.LLBL_Options);
			this.panel1.Controls.Add(this.LLBL_CheckBox);
			this.panel1.Location = new System.Drawing.Point(57, 50);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(938, 634);
			this.panel1.TabIndex = 3;
			// 
			// LBL_DateTimes
			// 
			this.LBL_DateTimes.AutoSize = true;
			this.LBL_DateTimes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_DateTimes.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LBL_DateTimes.Location = new System.Drawing.Point(17, 322);
			this.LBL_DateTimes.Name = "LBL_DateTimes";
			this.LBL_DateTimes.Size = new System.Drawing.Size(315, 32);
			this.LBL_DateTimes.TabIndex = 7;
			this.LBL_DateTimes.TabStop = true;
			this.LBL_DateTimes.Text = "DateTimesPicker-form";
			this.LBL_DateTimes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_DateTimes_LinkClicked);
			// 
			// LL_strings
			// 
			this.LL_strings.AutoSize = true;
			this.LL_strings.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LL_strings.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LL_strings.Location = new System.Drawing.Point(19, 280);
			this.LL_strings.Name = "LL_strings";
			this.LL_strings.Size = new System.Drawing.Size(195, 32);
			this.LL_strings.TabIndex = 6;
			this.LL_strings.TabStop = true;
			this.LL_strings.Text = "Strings-form";
			this.LL_strings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_strings_LinkClicked);
			// 
			// LL_Tax
			// 
			this.LL_Tax.AutoSize = true;
			this.LL_Tax.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LL_Tax.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LL_Tax.Location = new System.Drawing.Point(19, 238);
			this.LL_Tax.Name = "LL_Tax";
			this.LL_Tax.Size = new System.Drawing.Size(135, 32);
			this.LL_Tax.TabIndex = 5;
			this.LL_Tax.TabStop = true;
			this.LL_Tax.Text = "Tax-form";
			this.LL_Tax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Tax_LinkClicked);
			// 
			// LL_RGBshift
			// 
			this.LL_RGBshift.AutoSize = true;
			this.LL_RGBshift.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LL_RGBshift.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LL_RGBshift.Location = new System.Drawing.Point(19, 196);
			this.LL_RGBshift.Name = "LL_RGBshift";
			this.LL_RGBshift.Size = new System.Drawing.Size(225, 32);
			this.LL_RGBshift.TabIndex = 4;
			this.LL_RGBshift.TabStop = true;
			this.LL_RGBshift.Text = "RGB Shift-form";
			this.LL_RGBshift.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLBL_RGBshiftClicked);
			// 
			// LLBL_Future
			// 
			this.LLBL_Future.AutoSize = true;
			this.LLBL_Future.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LLBL_Future.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LLBL_Future.Location = new System.Drawing.Point(17, 154);
			this.LLBL_Future.Name = "LLBL_Future";
			this.LLBL_Future.Size = new System.Drawing.Size(210, 32);
			this.LLBL_Future.TabIndex = 3;
			this.LLBL_Future.TabStop = true;
			this.LLBL_Future.Text = "Multiple-form";
			this.LLBL_Future.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLBL_Future_LinkClicked);
			// 
			// LLB_fileIO
			// 
			this.LLB_fileIO.AutoSize = true;
			this.LLB_fileIO.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LLB_fileIO.LinkColor = System.Drawing.SystemColors.HotTrack;
			this.LLB_fileIO.Location = new System.Drawing.Point(19, 364);
			this.LLB_fileIO.Name = "LLB_fileIO";
			this.LLB_fileIO.Size = new System.Drawing.Size(195, 32);
			this.LLB_fileIO.TabIndex = 8;
			this.LLB_fileIO.TabStop = true;
			this.LLB_fileIO.Text = "fileIO-forms";
			this.LLB_fileIO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLB_fileIO_LinkClicked);
			// 
			// Init
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 721);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Init";
			this.Text = "Make a choice!";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel LLBL_CheckBox;
		private System.Windows.Forms.LinkLabel LLBL_Options;
		private System.Windows.Forms.Label LBL_PCAF;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel LLBL_Future;
		private System.Windows.Forms.LinkLabel LL_RGBshift;
		private System.Windows.Forms.LinkLabel LL_Tax;
		private System.Windows.Forms.LinkLabel LL_strings;
		private System.Windows.Forms.LinkLabel LBL_DateTimes;
		private System.Windows.Forms.LinkLabel LLB_fileIO;
	}
}