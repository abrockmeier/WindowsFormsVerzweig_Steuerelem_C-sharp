namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class Options
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
			this.LBL_top = new System.Windows.Forms.Label();
			this.LBL_bottom = new System.Windows.Forms.Label();
			this.BT_check = new System.Windows.Forms.Button();
			this.BT_switchC = new System.Windows.Forms.Button();
			this.RB_red = new System.Windows.Forms.RadioButton();
			this.RB_green = new System.Windows.Forms.RadioButton();
			this.RB_blue = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// LBL_top
			// 
			this.LBL_top.AutoSize = true;
			this.LBL_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_top.Location = new System.Drawing.Point(200, 80);
			this.LBL_top.Name = "LBL_top";
			this.LBL_top.Size = new System.Drawing.Size(74, 32);
			this.LBL_top.TabIndex = 0;
			this.LBL_top.Text = "blue";
			// 
			// LBL_bottom
			// 
			this.LBL_bottom.AutoSize = true;
			this.LBL_bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_bottom.Location = new System.Drawing.Point(190, 300);
			this.LBL_bottom.Name = "LBL_bottom";
			this.LBL_bottom.Size = new System.Drawing.Size(93, 32);
			this.LBL_bottom.TabIndex = 1;
			this.LBL_bottom.Text = "green";
			// 
			// BT_check
			// 
			this.BT_check.Location = new System.Drawing.Point(460, 74);
			this.BT_check.Name = "BT_check";
			this.BT_check.Size = new System.Drawing.Size(75, 23);
			this.BT_check.TabIndex = 3;
			this.BT_check.Text = "check!";
			this.BT_check.UseVisualStyleBackColor = true;
			this.BT_check.Click += new System.EventHandler(this.BT_check_Click);
			// 
			// BT_switchC
			// 
			this.BT_switchC.Location = new System.Drawing.Point(460, 297);
			this.BT_switchC.Name = "BT_switchC";
			this.BT_switchC.Size = new System.Drawing.Size(75, 23);
			this.BT_switchC.TabIndex = 4;
			this.BT_switchC.Text = "switch color";
			this.BT_switchC.UseVisualStyleBackColor = true;
			this.BT_switchC.Click += new System.EventHandler(this.BT_switchC_Click);
			// 
			// RB_red
			// 
			this.RB_red.AutoSize = true;
			this.RB_red.Location = new System.Drawing.Point(425, 150);
			this.RB_red.Name = "RB_red";
			this.RB_red.Size = new System.Drawing.Size(50, 21);
			this.RB_red.TabIndex = 1;
			this.RB_red.Text = "red";
			this.RB_red.UseVisualStyleBackColor = true;
			this.RB_red.CheckedChanged += new System.EventHandler(this.RB_red_CheckedChanged);
			this.RB_red.Click += new System.EventHandler(this.RB_color_changed);
			// 
			// RB_green
			// 
			this.RB_green.AutoSize = true;
			this.RB_green.Location = new System.Drawing.Point(425, 182);
			this.RB_green.Name = "RB_green";
			this.RB_green.Size = new System.Drawing.Size(66, 21);
			this.RB_green.TabIndex = 2;
			this.RB_green.Text = "green";
			this.RB_green.UseVisualStyleBackColor = true;
			this.RB_green.CheckedChanged += new System.EventHandler(this.RB_green_CheckedChanged);
			this.RB_green.Click += new System.EventHandler(this.RB_color_changed);
			// 
			// RB_blue
			// 
			this.RB_blue.AutoSize = true;
			this.RB_blue.Checked = true;
			this.RB_blue.Location = new System.Drawing.Point(425, 214);
			this.RB_blue.Name = "RB_blue";
			this.RB_blue.Size = new System.Drawing.Size(56, 21);
			this.RB_blue.TabIndex = 0;
			this.RB_blue.TabStop = true;
			this.RB_blue.Text = "blue";
			this.RB_blue.UseVisualStyleBackColor = true;
			this.RB_blue.CheckedChanged += new System.EventHandler(this.RB_blue_CheckedChanged);
			this.RB_blue.Click += new System.EventHandler(this.RB_color_changed);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.RB_blue);
			this.Controls.Add(this.RB_green);
			this.Controls.Add(this.RB_red);
			this.Controls.Add(this.BT_switchC);
			this.Controls.Add(this.BT_check);
			this.Controls.Add(this.LBL_bottom);
			this.Controls.Add(this.LBL_top);
			this.Name = "Options";
			this.Text = "Options";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LBL_top;
		private System.Windows.Forms.Label LBL_bottom;
		private System.Windows.Forms.Button BT_check;
		private System.Windows.Forms.Button BT_switchC;
		private System.Windows.Forms.RadioButton RB_red;
		private System.Windows.Forms.RadioButton RB_green;
		private System.Windows.Forms.RadioButton RB_blue;
	}
}