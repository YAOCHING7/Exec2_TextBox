using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//int people = Toint32(Text.Toint32);
			int people = Convert.ToInt32(textBox1.Text);
			int car = Convert.ToInt32(textBox2.Text);
			int resule = people * 60;
			int resule2 = car * 200;
			if (resule > resule2)
				this.label4.Text = Convert.ToString(resule2);
			else
				this.label4.Text = Convert.ToString(resule);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
