using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			if (textBox1.Text == "")
			{
				textBox1.Text = 0.ToString();
			}
			int number = int.Parse(textBox1.Text);
			textBox1.Text = number.ToString();
			if (number <= 100)
			{
				return;
			}
			textBox1.Text = textBox1.Text.Remove(2);
			

		}
	}
}
