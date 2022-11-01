using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{

			DateTime date1 = Convert.ToDateTime(this.textBox1.Text);
			DateTime date2 = DateTime.Now;

			if (date1.CompareTo(date2) > 0)
			{
				this.label1.Text = "今天過後";
			}
			else 
			{
				this.label1.Text = "今天或今天之前";
			}
		
		}
	}
}
