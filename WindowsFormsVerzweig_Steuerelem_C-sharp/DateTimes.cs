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
	public partial class DateTimes : Form
	{
		public DateTimes()
		{
			InitializeComponent();
		}

		private void DateTime_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
			this.Hide();
		}

		private void DateTime_Load(object sender, EventArgs e)
		{
			DTP_1.MinDate = new System.DateTime(2018, 12, 24);
			DTP_1.MaxDate = new System.DateTime(2019, 12, 31);
			DTP_1.Value = new System.DateTime(2019, 1, 18);
			
			DTP_2.CustomFormat = "dd.MM.yy";
			DTP_2.Format = DateTimePickerFormat.Custom;

			DTP_3.ShowUpDown = true;
			DTP_3.Format = DateTimePickerFormat.Short;

			DTP_4.ShowUpDown = true;
			DTP_4.Format = DateTimePickerFormat.Time;
		}
		private void DTP_ValueChanged(object sender, EventArgs e)
		{
			DateTimePicker DTP = sender as DateTimePicker;
			LBL_dateTOP.Text = DTP.Value + "";

			DateTime plusDay;
			plusDay = DTP.Value;
			plusDay = plusDay.AddDays(1);
			LBL_BOTTOM.Text = plusDay + "";

		}
	}
}
