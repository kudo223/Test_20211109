namespace Test_20211109
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_jmeno = new System.Windows.Forms.Label();
            this.label_stav = new System.Windows.Forms.Label();
            this.button_vlozit = new System.Windows.Forms.Button();
            this.textBox_vlozit = new System.Windows.Forms.TextBox();
            this.button_vyber = new System.Windows.Forms.Button();
            this.textBox_vybrat = new System.Windows.Forms.TextBox();
            this.button_platba = new System.Windows.Forms.Button();
            this.textBox_platba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_limit_vyber = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stav účtu:";
            // 
            // label_jmeno
            // 
            this.label_jmeno.AutoSize = true;
            this.label_jmeno.Location = new System.Drawing.Point(138, 38);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(38, 15);
            this.label_jmeno.TabIndex = 2;
            this.label_jmeno.Text = "label3";
            this.label_jmeno.Click += new System.EventHandler(this.label_jmeno_Click);
            // 
            // label_stav
            // 
            this.label_stav.AutoSize = true;
            this.label_stav.Location = new System.Drawing.Point(138, 68);
            this.label_stav.Name = "label_stav";
            this.label_stav.Size = new System.Drawing.Size(38, 15);
            this.label_stav.TabIndex = 3;
            this.label_stav.Text = "label3";
            // 
            // button_vlozit
            // 
            this.button_vlozit.Location = new System.Drawing.Point(21, 86);
            this.button_vlozit.Name = "button_vlozit";
            this.button_vlozit.Size = new System.Drawing.Size(111, 24);
            this.button_vlozit.TabIndex = 4;
            this.button_vlozit.Text = "Vložit peníze";
            this.button_vlozit.UseVisualStyleBackColor = true;
            this.button_vlozit.Click += new System.EventHandler(this.button_vlozit_Click);
            // 
            // textBox_vlozit
            // 
            this.textBox_vlozit.Location = new System.Drawing.Point(138, 87);
            this.textBox_vlozit.Name = "textBox_vlozit";
            this.textBox_vlozit.Size = new System.Drawing.Size(100, 23);
            this.textBox_vlozit.TabIndex = 5;
            // 
            // button_vyber
            // 
            this.button_vyber.Location = new System.Drawing.Point(21, 116);
            this.button_vyber.Name = "button_vyber";
            this.button_vyber.Size = new System.Drawing.Size(111, 23);
            this.button_vyber.TabIndex = 6;
            this.button_vyber.Text = "Vybrat peníze";
            this.button_vyber.UseVisualStyleBackColor = true;
            this.button_vyber.Click += new System.EventHandler(this.button_vyber_Click);
            // 
            // textBox_vybrat
            // 
            this.textBox_vybrat.Location = new System.Drawing.Point(138, 117);
            this.textBox_vybrat.Name = "textBox_vybrat";
            this.textBox_vybrat.Size = new System.Drawing.Size(100, 23);
            this.textBox_vybrat.TabIndex = 7;
            // 
            // button_platba
            // 
            this.button_platba.Location = new System.Drawing.Point(21, 145);
            this.button_platba.Name = "button_platba";
            this.button_platba.Size = new System.Drawing.Size(111, 23);
            this.button_platba.TabIndex = 8;
            this.button_platba.Text = "Platba";
            this.button_platba.UseVisualStyleBackColor = true;
            this.button_platba.Click += new System.EventHandler(this.button_platba_Click);
            // 
            // textBox_platba
            // 
            this.textBox_platba.Location = new System.Drawing.Point(138, 146);
            this.textBox_platba.Name = "textBox_platba";
            this.textBox_platba.Size = new System.Drawing.Size(100, 23);
            this.textBox_platba.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // button_limit_vyber
            // 
            this.button_limit_vyber.Location = new System.Drawing.Point(21, 174);
            this.button_limit_vyber.Name = "button_limit_vyber";
            this.button_limit_vyber.Size = new System.Drawing.Size(111, 43);
            this.button_limit_vyber.TabIndex = 11;
            this.button_limit_vyber.Text = "Přidat limit na výběr peněz";
            this.button_limit_vyber.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_limit_vyber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_platba);
            this.Controls.Add(this.button_platba);
            this.Controls.Add(this.textBox_vybrat);
            this.Controls.Add(this.button_vyber);
            this.Controls.Add(this.textBox_vlozit);
            this.Controls.Add(this.button_vlozit);
            this.Controls.Add(this.label_stav);
            this.Controls.Add(this.label_jmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_jmeno;
        private System.Windows.Forms.Label label_stav;
        private System.Windows.Forms.Button button_vlozit;
        private System.Windows.Forms.TextBox textBox_vlozit;
        private System.Windows.Forms.Button button_vyber;
        private System.Windows.Forms.TextBox textBox_vybrat;
        private System.Windows.Forms.Button button_platba;
        private System.Windows.Forms.TextBox textBox_platba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_limit_vyber;
        private System.Windows.Forms.TextBox textBox1;
    }
}

