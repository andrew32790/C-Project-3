namespace SQL_TEST
{
    partial class Vehicule
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
            this.button2 = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.Numetext3 = new System.Windows.Forms.TextBox();
            this.TagNume = new System.Windows.Forms.Label();
            this.listave = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 124);
            this.button1.TabIndex = 5;
            this.button1.Text = "Persoane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 107);
            this.button2.TabIndex = 6;
            this.button2.Text = "Adrese";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(403, 104);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(6);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(228, 77);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Numetext3
            // 
            this.Numetext3.Location = new System.Drawing.Point(327, 64);
            this.Numetext3.Name = "Numetext3";
            this.Numetext3.Size = new System.Drawing.Size(406, 31);
            this.Numetext3.TabIndex = 8;
            // 
            // TagNume
            // 
            this.TagNume.AutoSize = true;
            this.TagNume.Location = new System.Drawing.Point(398, 9);
            this.TagNume.Name = "TagNume";
            this.TagNume.Size = new System.Drawing.Size(277, 25);
            this.TagNume.TabIndex = 9;
            this.TagNume.Text = "Cautare vehicul dupa brand";
            // 
            // listave
            // 
            this.listave.FormattingEnabled = true;
            this.listave.ItemHeight = 25;
            this.listave.Location = new System.Drawing.Point(60, 200);
            this.listave.Name = "listave";
            this.listave.Size = new System.Drawing.Size(863, 304);
            this.listave.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "Register Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(842, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Vehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listave);
            this.Controls.Add(this.TagNume);
            this.Controls.Add(this.Numetext3);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Vehicule";
            this.Text = "Vehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox Numetext3;
        private System.Windows.Forms.Label TagNume;
        private System.Windows.Forms.ListBox listave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}