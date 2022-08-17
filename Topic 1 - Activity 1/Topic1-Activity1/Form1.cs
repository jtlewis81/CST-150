// Jamie Lewis
// CST-150
// 8/16/22
// The modifications to this auto-generated file are my own work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic1_Activity1
{
	public partial class Activity1 : Form
	{
		private string gender = "";

		public Activity1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void radbtn_male_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtn_male.Checked)
			{
				gender = "Mr.";
			}
		}

		private void radbtn_miss_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtn_miss.Checked)
			{
				gender = "Miss";
			}
		}

		private void radbtn_mrs_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtn_mrs.Checked)
			{
				gender = "Mrs.";
			}
		}

		private void radbtn_ms_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtn_ms.Checked)
			{
				gender = "Ms.";
			}
		}

		private void text_fname_TextChanged(object sender, EventArgs e)
		{

		}

		private void text_lname_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_hello_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello to you too, " + gender + " " + text_fname.Text + " " + text_lname.Text + "!");
		}
	}
}
