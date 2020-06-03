namespace SQL_TEST
{
    partial class Dashboard
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
            this.listapersoane = new System.Windows.Forms.ListBox();
            this.Numetext = new System.Windows.Forms.TextBox();
            this.TagNume = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listapersoane
            // 
            this.listapersoane.FormattingEnabled = true;
            this.listapersoane.ItemHeight = 25;
            this.listapersoane.Location = new System.Drawing.Point(40, 149);
            this.listapersoane.Name = "listapersoane";
            this.listapersoane.Size = new System.Drawing.Size(866, 404);
            this.listapersoane.TabIndex = 0;
            // 
            // Numetext
            // 
            this.Numetext.Location = new System.Drawing.Point(356, 28);
            this.Numetext.Name = "Numetext";
            this.Numetext.Size = new System.Drawing.Size(257, 31);
            this.Numetext.TabIndex = 1;
            // 
            // TagNume
            // 
            this.TagNume.AutoSize = true;
            this.TagNume.Location = new System.Drawing.Point(389, 0);
            this.TagNume.Name = "TagNume";
            this.TagNume.Size = new System.Drawing.Size(201, 25);
            this.TagNume.TabIndex = 2;
            this.TagNume.Text = "Cautare dupa nume";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(403, 65);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(145, 64);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adrese";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 96);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vehicule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "Register Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(826, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 638);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.TagNume);
            this.Controls.Add(this.Numetext);
            this.Controls.Add(this.listapersoane);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listapersoane;
        private System.Windows.Forms.TextBox Numetext;
        private System.Windows.Forms.Label TagNume;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

