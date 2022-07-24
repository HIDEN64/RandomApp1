using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomApp1 {
	public partial class Form3 : Form {
		public Form3() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			this.Hide();
			var nouForm = new Form5();
            nouForm.Closed += (s, args) => this.Close(); 
			nouForm.Show();
		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void Form3_Load(object sender, EventArgs e) {

		}
	}
}
