using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomApp1 {
	public partial class Form4 : Form {
		public Form4() {
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e) {

		}

        private void thxbtn_Click(object sender, EventArgs e) {
            this.Hide();
            var ywForm = new Form6();
            ywForm.Closed += (s, args) => this.Close(); 
            ywForm.Show();
        }

		private void Form4_Load(object sender, EventArgs e) {

		}
	}
}
