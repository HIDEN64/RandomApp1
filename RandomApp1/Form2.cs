using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomApp1 {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			this.Hide();
			var medalForm = new Form4();
            medalForm.Closed += (s, args) => this.Close(); 
			medalForm.Show();
		}
	}
}
