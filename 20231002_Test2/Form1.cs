using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231002_Test2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

		}
			

		private void button1_Click(object sender, EventArgs e) {
			label1.Text = "ブランチ４だよ";
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
			label1.BackColor = Color.HotPink;
		}

		private void label1_MouseLeave(object sender, EventArgs e)
		{
			label1.BackColor = Color.Transparent;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				label1.BackColor = Color.LightSkyBlue;
			}
			else {
				label1.BackColor = Color.Transparent;
			}
		}
	}

}
