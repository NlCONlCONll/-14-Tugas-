namespace _14__Tugas
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(13, 13);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(128, 17);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan kalimat: ";
            this.labelKalimat.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(12, 44);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(117, 17);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan huruf: ";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(289, 47);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(57, 17);
            this.labelMenjadi.TabIndex = 2;
            this.labelMenjadi.Text = "Menjadi";
            this.labelMenjadi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(138, 93);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(369, 23);
            this.button.TabIndex = 3;
            this.button.Text = "KONVERSI!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // tBoxInput
            // 
            this.tBoxInput.Location = new System.Drawing.Point(138, 10);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(369, 22);
            this.tBoxInput.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 22);
            this.textBox2.TabIndex = 6;
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(13, 164);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(47, 17);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil: ";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(138, 164);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 17);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tBoxInput);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox tBoxInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
    }
}

