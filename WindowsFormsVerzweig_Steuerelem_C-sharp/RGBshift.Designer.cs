namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class RGBshift
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
			this.P_canvas = new System.Windows.Forms.Panel();
			this.LBL_red = new System.Windows.Forms.Label();
			this.LBL_green = new System.Windows.Forms.Label();
			this.LBL_blue = new System.Windows.Forms.Label();
			this.TB_red = new System.Windows.Forms.TrackBar();
			this.TB_green = new System.Windows.Forms.TrackBar();
			this.TB_blue = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.TB_red)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TB_green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TB_blue)).BeginInit();
			this.SuspendLayout();
			// 
			// P_canvas
			// 
			this.P_canvas.Location = new System.Drawing.Point(446, 49);
			this.P_canvas.Name = "P_canvas";
			this.P_canvas.Size = new System.Drawing.Size(300, 300);
			this.P_canvas.TabIndex = 0;
			this.P_canvas.BackgroundImageChanged += new System.EventHandler(this.P_canvas_BackgroundImageChanged);
			// 
			// LBL_red
			// 
			this.LBL_red.AutoSize = true;
			this.LBL_red.Location = new System.Drawing.Point(338, 91);
			this.LBL_red.Name = "LBL_red";
			this.LBL_red.Size = new System.Drawing.Size(30, 17);
			this.LBL_red.TabIndex = 1;
			this.LBL_red.Text = "Rot";
			// 
			// LBL_green
			// 
			this.LBL_green.AutoSize = true;
			this.LBL_green.Location = new System.Drawing.Point(338, 172);
			this.LBL_green.Name = "LBL_green";
			this.LBL_green.Size = new System.Drawing.Size(40, 17);
			this.LBL_green.TabIndex = 2;
			this.LBL_green.Text = "Grün";
			// 
			// LBL_blue
			// 
			this.LBL_blue.AutoSize = true;
			this.LBL_blue.Location = new System.Drawing.Point(338, 254);
			this.LBL_blue.Name = "LBL_blue";
			this.LBL_blue.Size = new System.Drawing.Size(36, 17);
			this.LBL_blue.TabIndex = 3;
			this.LBL_blue.Text = "Blau";
			// 
			// TB_red
			// 
			this.TB_red.LargeChange = 32;
			this.TB_red.Location = new System.Drawing.Point(25, 91);
			this.TB_red.Maximum = 255;
			this.TB_red.Name = "TB_red";
			this.TB_red.Size = new System.Drawing.Size(275, 56);
			this.TB_red.TabIndex = 4;
			this.TB_red.TickFrequency = 16;
			this.TB_red.ValueChanged += new System.EventHandler(this.TB_red_ValueChanged);
			// 
			// TB_green
			// 
			this.TB_green.LargeChange = 32;
			this.TB_green.Location = new System.Drawing.Point(25, 172);
			this.TB_green.Maximum = 255;
			this.TB_green.Name = "TB_green";
			this.TB_green.Size = new System.Drawing.Size(275, 56);
			this.TB_green.TabIndex = 5;
			this.TB_green.TickFrequency = 16;
			this.TB_green.ValueChanged += new System.EventHandler(this.TB_green_ValueChanged);
			// 
			// TB_blue
			// 
			this.TB_blue.LargeChange = 32;
			this.TB_blue.Location = new System.Drawing.Point(25, 254);
			this.TB_blue.Maximum = 255;
			this.TB_blue.Name = "TB_blue";
			this.TB_blue.Size = new System.Drawing.Size(275, 56);
			this.TB_blue.TabIndex = 6;
			this.TB_blue.TickFrequency = 16;
			this.TB_blue.ValueChanged += new System.EventHandler(this.TB_blue_ValueChanged);
			// 
			// RGBshift
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 403);
			this.Controls.Add(this.TB_blue);
			this.Controls.Add(this.TB_green);
			this.Controls.Add(this.TB_red);
			this.Controls.Add(this.LBL_blue);
			this.Controls.Add(this.LBL_green);
			this.Controls.Add(this.LBL_red);
			this.Controls.Add(this.P_canvas);
			this.Name = "RGBshift";
			this.Text = "RGBshift";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RGBshift_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.TB_red)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TB_green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TB_blue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel P_canvas;
		private System.Windows.Forms.Label LBL_red;
		private System.Windows.Forms.Label LBL_green;
		private System.Windows.Forms.Label LBL_blue;
		private System.Windows.Forms.TrackBar TB_red;
		private System.Windows.Forms.TrackBar TB_green;
		private System.Windows.Forms.TrackBar TB_blue;
	}
}