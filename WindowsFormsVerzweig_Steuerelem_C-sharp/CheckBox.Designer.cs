namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class CheckBox
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.LBL_one = new System.Windows.Forms.Label();
			this.LBL_two = new System.Windows.Forms.Label();
			this.BT_supervisor = new System.Windows.Forms.Button();
			this.CB_CheckBox = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LBL_one
			// 
			this.LBL_one.AutoSize = true;
			this.LBL_one.Location = new System.Drawing.Point(232, 210);
			this.LBL_one.Name = "LBL_one";
			this.LBL_one.Size = new System.Drawing.Size(27, 17);
			this.LBL_one.TabIndex = 0;
			this.LBL_one.Text = "Off";
			// 
			// LBL_two
			// 
			this.LBL_two.AutoSize = true;
			this.LBL_two.Location = new System.Drawing.Point(232, 296);
			this.LBL_two.Name = "LBL_two";
			this.LBL_two.Size = new System.Drawing.Size(27, 17);
			this.LBL_two.TabIndex = 1;
			this.LBL_two.Text = "On";
			// 
			// BT_supervisor
			// 
			this.BT_supervisor.Location = new System.Drawing.Point(375, 207);
			this.BT_supervisor.Name = "BT_supervisor";
			this.BT_supervisor.Size = new System.Drawing.Size(165, 36);
			this.BT_supervisor.TabIndex = 2;
			this.BT_supervisor.Text = "Supervise checkBox";
			this.BT_supervisor.UseVisualStyleBackColor = true;
			this.BT_supervisor.Click += new System.EventHandler(this.button1_Click);
			// 
			// CB_CheckBox
			// 
			this.CB_CheckBox.AutoSize = true;
			this.CB_CheckBox.Enabled = false;
			this.CB_CheckBox.Location = new System.Drawing.Point(352, 295);
			this.CB_CheckBox.Name = "CB_CheckBox";
			this.CB_CheckBox.Size = new System.Drawing.Size(76, 21);
			this.CB_CheckBox.TabIndex = 3;
			this.CB_CheckBox.Text = "switch?";
			this.CB_CheckBox.UseVisualStyleBackColor = true;
			this.CB_CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(375, 345);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(165, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "toggle switch";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.CB_CheckBox);
			this.Controls.Add(this.BT_supervisor);
			this.Controls.Add(this.LBL_two);
			this.Controls.Add(this.LBL_one);
			this.Name = "CheckBox";
			this.Text = "Check?";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckBox_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LBL_one;
		private System.Windows.Forms.Label LBL_two;
		private System.Windows.Forms.Button BT_supervisor;
		private System.Windows.Forms.CheckBox CB_CheckBox;
		private System.Windows.Forms.Button button2;
	}
}

