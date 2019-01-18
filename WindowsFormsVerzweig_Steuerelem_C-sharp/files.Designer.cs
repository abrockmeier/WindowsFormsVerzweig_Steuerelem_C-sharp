namespace WindowsFormsVerzweig_Steuerelem_C_sharp
{
	partial class Files
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
			this.BT_read = new System.Windows.Forms.Button();
			this.LBL_output = new System.Windows.Forms.Label();
			this.BT_write = new System.Windows.Forms.Button();
			this.TB_input = new System.Windows.Forms.TextBox();
			this.BT_exception = new System.Windows.Forms.Button();
			this.BT_Path = new System.Windows.Forms.Button();
			this.BT_fileExists = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BT_read
			// 
			this.BT_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_read.Location = new System.Drawing.Point(39, 44);
			this.BT_read.Name = "BT_read";
			this.BT_read.Size = new System.Drawing.Size(162, 39);
			this.BT_read.TabIndex = 0;
			this.BT_read.Text = "read File";
			this.BT_read.UseVisualStyleBackColor = true;
			this.BT_read.Click += new System.EventHandler(this.BT_read_Click);
			// 
			// LBL_output
			// 
			this.LBL_output.AutoSize = true;
			this.LBL_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBL_output.Location = new System.Drawing.Point(36, 109);
			this.LBL_output.Name = "LBL_output";
			this.LBL_output.Size = new System.Drawing.Size(60, 20);
			this.LBL_output.TabIndex = 1;
			this.LBL_output.Text = "output:";
			// 
			// BT_write
			// 
			this.BT_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_write.Location = new System.Drawing.Point(249, 44);
			this.BT_write.Name = "BT_write";
			this.BT_write.Size = new System.Drawing.Size(162, 39);
			this.BT_write.TabIndex = 2;
			this.BT_write.Text = "write File";
			this.BT_write.UseVisualStyleBackColor = true;
			this.BT_write.Click += new System.EventHandler(this.BT_write_Click);
			// 
			// TB_input
			// 
			this.TB_input.Location = new System.Drawing.Point(249, 127);
			this.TB_input.Multiline = true;
			this.TB_input.Name = "TB_input";
			this.TB_input.Size = new System.Drawing.Size(162, 192);
			this.TB_input.TabIndex = 3;
			// 
			// BT_exception
			// 
			this.BT_exception.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_exception.Location = new System.Drawing.Point(565, 147);
			this.BT_exception.Name = "BT_exception";
			this.BT_exception.Size = new System.Drawing.Size(162, 39);
			this.BT_exception.TabIndex = 4;
			this.BT_exception.Text = "exception";
			this.BT_exception.UseVisualStyleBackColor = true;
			this.BT_exception.Click += new System.EventHandler(this.BT_exception_Click);
			// 
			// BT_Path
			// 
			this.BT_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_Path.Location = new System.Drawing.Point(565, 202);
			this.BT_Path.Name = "BT_Path";
			this.BT_Path.Size = new System.Drawing.Size(162, 39);
			this.BT_Path.TabIndex = 5;
			this.BT_Path.Text = "path";
			this.BT_Path.UseVisualStyleBackColor = true;
			// 
			// BT_fileExists
			// 
			this.BT_fileExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BT_fileExists.Location = new System.Drawing.Point(565, 90);
			this.BT_fileExists.Name = "BT_fileExists";
			this.BT_fileExists.Size = new System.Drawing.Size(162, 39);
			this.BT_fileExists.TabIndex = 6;
			this.BT_fileExists.Text = "file existing?";
			this.BT_fileExists.UseVisualStyleBackColor = true;
			this.BT_fileExists.Click += new System.EventHandler(this.BT_fileExists_Click);
			// 
			// Files
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BT_fileExists);
			this.Controls.Add(this.BT_Path);
			this.Controls.Add(this.BT_exception);
			this.Controls.Add(this.TB_input);
			this.Controls.Add(this.BT_write);
			this.Controls.Add(this.LBL_output);
			this.Controls.Add(this.BT_read);
			this.Name = "Files";
			this.Text = "Files";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Files_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BT_read;
		private System.Windows.Forms.Label LBL_output;
		private System.Windows.Forms.Button BT_write;
		private System.Windows.Forms.TextBox TB_input;
		private System.Windows.Forms.Button BT_exception;
		private System.Windows.Forms.Button BT_Path;
		private System.Windows.Forms.Button BT_fileExists;
	}
}