
namespace demo5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckBox1 = new System.Windows.Forms.CheckBox();
            this.ckBox2 = new System.Windows.Forms.CheckBox();
            this.ckBox3 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckBox1
            // 
            this.ckBox1.AutoSize = true;
            this.ckBox1.Location = new System.Drawing.Point(156, 95);
            this.ckBox1.Name = "ckBox1";
            this.ckBox1.Size = new System.Drawing.Size(150, 21);
            this.ckBox1.TabIndex = 0;
            this.ckBox1.Text = "Nhập môn lập trình";
            this.ckBox1.UseVisualStyleBackColor = true;
            this.ckBox1.CheckedChanged += new System.EventHandler(this.ckBox1_CheckedChanged);
            // 
            // ckBox2
            // 
            this.ckBox2.AutoSize = true;
            this.ckBox2.Location = new System.Drawing.Point(156, 152);
            this.ckBox2.Name = "ckBox2";
            this.ckBox2.Size = new System.Drawing.Size(193, 21);
            this.ckBox2.TabIndex = 1;
            this.ckBox2.Text = "Lập trình hướng đối tượng";
            this.ckBox2.UseVisualStyleBackColor = true;
            this.ckBox2.CheckedChanged += new System.EventHandler(this.ckBox2_CheckedChanged);
            // 
            // ckBox3
            // 
            this.ckBox3.AutoSize = true;
            this.ckBox3.Location = new System.Drawing.Point(156, 205);
            this.ckBox3.Name = "ckBox3";
            this.ckBox3.Size = new System.Drawing.Size(150, 21);
            this.ckBox3.TabIndex = 2;
            this.ckBox3.Text = "Lập trình trực quan";
            this.ckBox3.UseVisualStyleBackColor = true;
            this.ckBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(246, 299);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit\r\n";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ckBox3);
            this.Controls.Add(this.ckBox2);
            this.Controls.Add(this.ckBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBox1;
        private System.Windows.Forms.CheckBox ckBox2;
        private System.Windows.Forms.CheckBox ckBox3;
        private System.Windows.Forms.Button btnSubmit;
    }
}

