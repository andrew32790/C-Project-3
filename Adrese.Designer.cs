namespace SQL_TEST
{
    partial class Adrese
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
            this.button1 = new System.Windows.Forms.Button();
            this.Numetext2 = new System.Windows.Forms.TextBox();
            this.TagNume = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.listaadrese = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vehicule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Numetext2
            // 
            this.Numetext2.Location = new System.Drawing.Point(454, 83);
            this.Numetext2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Numetext2.Name = "Numetext2";
            this.Numetext2.Size = new System.Drawing.Size(510, 31);
            this.Numetext2.TabIndex = 2;
            // 
            // TagNume
            // 
            this.TagNume.AutoSize = true;
            this.TagNume.Location = new System.Drawing.Point(545, 29);
            this.TagNume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TagNume.Name = "TagNume";
            this.TagNume.Size = new System.Drawing.Size(353, 25);
            this.TagNume.TabIndex = 3;
            this.TagNume.Text = "Cautare adresa dupa numele strazii";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(573, 126);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(268, 61);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // listaadrese
            // 
            this.listaadrese.FormattingEnabled = true;
            this.listaadrese.ItemHeight = 25;
            this.listaadrese.Location = new System.Drawing.Point(48, 199);
            this.listaadrese.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listaadrese.Name = "listaadrese";
            this.listaadrese.Size = new System.Drawing.Size(1319, 254);
            this.listaadrese.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1183, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 106);
            this.button2.TabIndex = 6;
            this.button2.Text = "Persoane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 74);
            this.button3.TabIndex = 7;
            this.button3.Text = "Register Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1286, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Adrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 619);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listaadrese);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.TagNume);
            this.Controls.Add(this.Numetext2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Adrese";
            this.Text = "Adrese";
            this.Load += new System.EventHandler(this.Adrese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Numetext2;
        private System.Windows.Forms.Label TagNume;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.ListBox listaadrese;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}