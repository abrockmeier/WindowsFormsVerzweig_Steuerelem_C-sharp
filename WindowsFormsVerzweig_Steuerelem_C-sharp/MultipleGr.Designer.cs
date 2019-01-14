namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class MultipleGr
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
			this.LBLCity_Billet = new System.Windows.Forms.Label();
			this.GB_Location = new System.Windows.Forms.GroupBox();
			this.RB_Rom = new System.Windows.Forms.RadioButton();
			this.RB_Paris = new System.Windows.Forms.RadioButton();
			this.RB_Berlin = new System.Windows.Forms.RadioButton();
			this.GB_Billet = new System.Windows.Forms.GroupBox();
			this.RB_Hotel = new System.Windows.Forms.RadioButton();
			this.RB_Pension = new System.Windows.Forms.RadioButton();
			this.RB_Appartment = new System.Windows.Forms.RadioButton();
			this.GB_Location.SuspendLayout();
			this.GB_Billet.SuspendLayout();
			this.SuspendLayout();
			// 
			// LBLCity_Billet
			// 
			this.LBLCity_Billet.AutoSize = true;
			this.LBLCity_Billet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLCity_Billet.Location = new System.Drawing.Point(79, 153);
			this.LBLCity_Billet.Name = "LBLCity_Billet";
			this.LBLCity_Billet.Size = new System.Drawing.Size(111, 25);
			this.LBLCity_Billet.TabIndex = 0;
			this.LBLCity_Billet.Text = "\"City, Billet\"";
			// 
			// GB_Location
			// 
			this.GB_Location.Controls.Add(this.RB_Rom);
			this.GB_Location.Controls.Add(this.RB_Paris);
			this.GB_Location.Controls.Add(this.RB_Berlin);
			this.GB_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GB_Location.Location = new System.Drawing.Point(84, 278);
			this.GB_Location.Name = "GB_Location";
			this.GB_Location.Size = new System.Drawing.Size(218, 250);
			this.GB_Location.TabIndex = 1;
			this.GB_Location.TabStop = false;
			this.GB_Location.Text = "Location:";
			// 
			// RB_Rom
			// 
			this.RB_Rom.AutoSize = true;
			this.RB_Rom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Rom.Location = new System.Drawing.Point(43, 173);
			this.RB_Rom.Name = "RB_Rom";
			this.RB_Rom.Size = new System.Drawing.Size(73, 29);
			this.RB_Rom.TabIndex = 2;
			this.RB_Rom.Text = "Rom";
			this.RB_Rom.UseVisualStyleBackColor = true;
			this.RB_Rom.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeCity);
			// 
			// RB_Paris
			// 
			this.RB_Paris.AutoSize = true;
			this.RB_Paris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Paris.Location = new System.Drawing.Point(43, 129);
			this.RB_Paris.Name = "RB_Paris";
			this.RB_Paris.Size = new System.Drawing.Size(77, 29);
			this.RB_Paris.TabIndex = 1;
			this.RB_Paris.Text = "Paris";
			this.RB_Paris.UseVisualStyleBackColor = true;
			this.RB_Paris.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeCity);
			// 
			// RB_Berlin
			// 
			this.RB_Berlin.AutoSize = true;
			this.RB_Berlin.Checked = true;
			this.RB_Berlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Berlin.Location = new System.Drawing.Point(43, 87);
			this.RB_Berlin.Name = "RB_Berlin";
			this.RB_Berlin.Size = new System.Drawing.Size(82, 29);
			this.RB_Berlin.TabIndex = 0;
			this.RB_Berlin.TabStop = true;
			this.RB_Berlin.Text = "Berlin";
			this.RB_Berlin.UseVisualStyleBackColor = true;
			this.RB_Berlin.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeCity);
			// 
			// GB_Billet
			// 
			this.GB_Billet.Controls.Add(this.RB_Hotel);
			this.GB_Billet.Controls.Add(this.RB_Pension);
			this.GB_Billet.Controls.Add(this.RB_Appartment);
			this.GB_Billet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GB_Billet.Location = new System.Drawing.Point(521, 278);
			this.GB_Billet.Name = "GB_Billet";
			this.GB_Billet.Size = new System.Drawing.Size(218, 250);
			this.GB_Billet.TabIndex = 2;
			this.GB_Billet.TabStop = false;
			this.GB_Billet.Text = "Billet:";
			// 
			// RB_Hotel
			// 
			this.RB_Hotel.AutoSize = true;
			this.RB_Hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Hotel.Location = new System.Drawing.Point(34, 173);
			this.RB_Hotel.Name = "RB_Hotel";
			this.RB_Hotel.Size = new System.Drawing.Size(78, 29);
			this.RB_Hotel.TabIndex = 2;
			this.RB_Hotel.Text = "Hotel";
			this.RB_Hotel.UseVisualStyleBackColor = true;
			this.RB_Hotel.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeBillet);
			// 
			// RB_Pension
			// 
			this.RB_Pension.AutoSize = true;
			this.RB_Pension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Pension.Location = new System.Drawing.Point(34, 129);
			this.RB_Pension.Name = "RB_Pension";
			this.RB_Pension.Size = new System.Drawing.Size(104, 29);
			this.RB_Pension.TabIndex = 1;
			this.RB_Pension.Text = "Pension";
			this.RB_Pension.UseVisualStyleBackColor = true;
			this.RB_Pension.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeBillet);
			// 
			// RB_Appartment
			// 
			this.RB_Appartment.AutoSize = true;
			this.RB_Appartment.Checked = true;
			this.RB_Appartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RB_Appartment.Location = new System.Drawing.Point(34, 87);
			this.RB_Appartment.Name = "RB_Appartment";
			this.RB_Appartment.Size = new System.Drawing.Size(134, 29);
			this.RB_Appartment.TabIndex = 0;
			this.RB_Appartment.TabStop = true;
			this.RB_Appartment.Text = "Appartment";
			this.RB_Appartment.UseVisualStyleBackColor = true;
			this.RB_Appartment.CheckedChanged += new System.EventHandler(this.RB_CheckedChangeBillet);
			// 
			// MultipleGr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 608);
			this.Controls.Add(this.GB_Billet);
			this.Controls.Add(this.GB_Location);
			this.Controls.Add(this.LBLCity_Billet);
			this.Name = "MultipleGr";
			this.Text = "multipleGroups";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultipleGr_FormClosing);
			this.GB_Location.ResumeLayout(false);
			this.GB_Location.PerformLayout();
			this.GB_Billet.ResumeLayout(false);
			this.GB_Billet.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LBLCity_Billet;
		private System.Windows.Forms.GroupBox GB_Location;
		private System.Windows.Forms.RadioButton RB_Rom;
		private System.Windows.Forms.RadioButton RB_Paris;
		private System.Windows.Forms.RadioButton RB_Berlin;
		private System.Windows.Forms.GroupBox GB_Billet;
		private System.Windows.Forms.RadioButton RB_Hotel;
		private System.Windows.Forms.RadioButton RB_Pension;
		private System.Windows.Forms.RadioButton RB_Appartment;
	}
}