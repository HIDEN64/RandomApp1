namespace RandomApp1 {
	partial class Form6 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.ywtxt = new System.Windows.Forms.Label();
			this.btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ywtxt
			// 
			this.ywtxt.AutoSize = true;
			this.ywtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ywtxt.Location = new System.Drawing.Point(82, 24);
			this.ywtxt.Name = "ywtxt";
			this.ywtxt.Size = new System.Drawing.Size(105, 15);
			this.ywtxt.TabIndex = 0;
			this.ywtxt.Text = "you\'re welcome c:";
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(96, 57);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(75, 23);
			this.btn.TabIndex = 1;
			this.btn.Text = ":)";
			this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 92);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.ywtxt);
			this.Name = "Form6";
			this.Text = "Form6";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label ywtxt;
		private System.Windows.Forms.Button btn;
	}
}