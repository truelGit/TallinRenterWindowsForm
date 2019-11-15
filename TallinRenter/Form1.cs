using System;
using System.Globalization;
using System.Windows.Forms;

namespace TallinRenter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			var kvarplata = Parse(txtKvarplata.Text);
			var electricity = Parse(txtElectricity.Text);
			var gas = Parse(txtGas.Text);

			var total = kvarplata + electricity + gas;

			var month = DateTime.Now.AddMonths(-1).ToString("MMMM");
			txtResult.Text = $@"Привет, расчет за {month} : аренда 22000 + кварплата {kvarplata} + электричество {electricity} + газ {gas} = {total}";
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtResult.Text);
		}

		private decimal Parse(string value)
		{
			return decimal.Parse(value.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator), NumberStyles.Any, CultureInfo.InvariantCulture);
		}
	}
}
