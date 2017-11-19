namespace Les1_Opgave01
{
    partial class Rente
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
            this.bedragtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bedragbox = new System.Windows.Forms.TextBox();
            this.rentebox = new System.Windows.Forms.TextBox();
            this.calcbut = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bedragtxt
            // 
            this.bedragtxt.AutoSize = true;
            this.bedragtxt.Location = new System.Drawing.Point(61, 9);
            this.bedragtxt.Name = "bedragtxt";
            this.bedragtxt.Size = new System.Drawing.Size(44, 13);
            this.bedragtxt.TabIndex = 0;
            this.bedragtxt.Text = "Bedrag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rentepercentage:";
            // 
            // bedragbox
            // 
            this.bedragbox.Location = new System.Drawing.Point(109, 9);
            this.bedragbox.Name = "bedragbox";
            this.bedragbox.Size = new System.Drawing.Size(100, 20);
            this.bedragbox.TabIndex = 2;
            // 
            // rentebox
            // 
            this.rentebox.Location = new System.Drawing.Point(109, 32);
            this.rentebox.Name = "rentebox";
            this.rentebox.Size = new System.Drawing.Size(100, 20);
            this.rentebox.TabIndex = 3;
            // 
            // calcbut
            // 
            this.calcbut.Location = new System.Drawing.Point(109, 70);
            this.calcbut.Name = "calcbut";
            this.calcbut.Size = new System.Drawing.Size(100, 23);
            this.calcbut.TabIndex = 4;
            this.calcbut.Text = "Bereken";
            this.calcbut.UseVisualStyleBackColor = true;
            this.calcbut.Click += new System.EventHandler(this.calcbut_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(306, 9);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(36, 13);
            this.Answer1.TabIndex = 5;
            this.Answer1.Text = "tekst1";
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(306, 22);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(39, 13);
            this.Answer2.TabIndex = 6;
            this.Answer2.Text = "tekst 2";
            // 
            // Rente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 290);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.calcbut);
            this.Controls.Add(this.rentebox);
            this.Controls.Add(this.bedragbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bedragtxt);
            this.Name = "Rente";
            this.Text = "Rente";
            this.Load += new System.EventHandler(this.Rente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bedragtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bedragbox;
        private System.Windows.Forms.TextBox rentebox;
        private System.Windows.Forms.Button calcbut;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Label Answer2;
    }
}

