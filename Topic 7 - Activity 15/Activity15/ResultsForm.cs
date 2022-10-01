
// background image source: https://clipart.me/download/rainbow-burst-vector-graphic-22071

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
	public partial class ResultsForm : Form
	{
		public ResultsForm()
		{
			InitializeComponent();
		}

		private void ResultsForm_Load(object sender, EventArgs e)
		{
			luckyNumber_label.Text = MainForm.LuckyNumber.ToString();


		}
	}
}
