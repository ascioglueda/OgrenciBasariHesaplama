namespace WinFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Degerlendirme = new System.Windows.Forms.ListBox();
            this.textBoxtxtOgrenciNo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(488, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "OgrenciEkle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Degerlendirme
            // 
            this.Degerlendirme.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Degerlendirme.FormattingEnabled = true;
            this.Degerlendirme.ItemHeight = 20;
            this.Degerlendirme.Location = new System.Drawing.Point(222, 73);
            this.Degerlendirme.Name = "Degerlendirme";
            this.Degerlendirme.Size = new System.Drawing.Size(209, 104);
            this.Degerlendirme.TabIndex = 1;
            // 
            // textBoxtxtOgrenciNo1
            // 
            this.textBoxtxtOgrenciNo1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtxtOgrenciNo1.Location = new System.Drawing.Point(222, 211);
            this.textBoxtxtOgrenciNo1.Name = "textBoxtxtOgrenciNo1";
            this.textBoxtxtOgrenciNo1.Size = new System.Drawing.Size(209, 27);
            this.textBoxtxtOgrenciNo1.TabIndex = 2;
            this.textBoxtxtOgrenciNo1.Text = "OgrenciNo";
            this.textBoxtxtOgrenciNo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "OgrenciAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "OgrenciSoyadi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(63, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notlar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(488, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "NotHesapla";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(488, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(488, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "DegerlendirmeEkle";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Location = new System.Drawing.Point(488, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "SinifOrtalamasi";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Location = new System.Drawing.Point(488, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 29);
            this.button6.TabIndex = 10;
            this.button6.Text = "DegerlendirmeyeKatilanlarinOrtalamasi";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxtxtOgrenciNo1);
            this.Controls.Add(this.Degerlendirme);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox Degerlendirme;
        private TextBox textBoxtxtOgrenciNo1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}