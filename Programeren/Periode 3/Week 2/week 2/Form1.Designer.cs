namespace week_2
{
    partial class banaan
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
            this.buthero = new System.Windows.Forms.Button();
            this.txthero = new System.Windows.Forms.TextBox();
            this.txtvil = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtside = new System.Windows.Forms.TextBox();
            this.butvil = new System.Windows.Forms.Button();
            this.bitmin = new System.Windows.Forms.Button();
            this.butside = new System.Windows.Forms.Button();
            this.herobox = new System.Windows.Forms.ListBox();
            this.vilbox = new System.Windows.Forms.ListBox();
            this.sidebox = new System.Windows.Forms.ListBox();
            this.minbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buthero
            // 
            this.buthero.Location = new System.Drawing.Point(50, 58);
            this.buthero.Name = "buthero";
            this.buthero.Size = new System.Drawing.Size(75, 23);
            this.buthero.TabIndex = 0;
            this.buthero.Text = "Add Hero";
            this.buthero.UseVisualStyleBackColor = true;
            // 
            // txthero
            // 
            this.txthero.Location = new System.Drawing.Point(38, 32);
            this.txthero.Name = "txthero";
            this.txthero.Size = new System.Drawing.Size(100, 20);
            this.txthero.TabIndex = 1;
            // 
            // txtvil
            // 
            this.txtvil.Location = new System.Drawing.Point(442, 32);
            this.txtvil.Name = "txtvil";
            this.txtvil.Size = new System.Drawing.Size(100, 20);
            this.txtvil.TabIndex = 2;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(442, 185);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 20);
            this.txtmin.TabIndex = 3;
            // 
            // txtside
            // 
            this.txtside.Location = new System.Drawing.Point(38, 185);
            this.txtside.Name = "txtside";
            this.txtside.Size = new System.Drawing.Size(100, 20);
            this.txtside.TabIndex = 4;
            // 
            // butvil
            // 
            this.butvil.Location = new System.Drawing.Point(455, 58);
            this.butvil.Name = "butvil";
            this.butvil.Size = new System.Drawing.Size(75, 23);
            this.butvil.TabIndex = 5;
            this.butvil.Text = "Add Villain";
            this.butvil.UseVisualStyleBackColor = true;
            // 
            // bitmin
            // 
            this.bitmin.Location = new System.Drawing.Point(455, 211);
            this.bitmin.Name = "bitmin";
            this.bitmin.Size = new System.Drawing.Size(75, 23);
            this.bitmin.TabIndex = 6;
            this.bitmin.Text = "Add minion";
            this.bitmin.UseVisualStyleBackColor = true;
            // 
            // butside
            // 
            this.butside.Location = new System.Drawing.Point(38, 211);
            this.butside.Name = "butside";
            this.butside.Size = new System.Drawing.Size(100, 23);
            this.butside.TabIndex = 7;
            this.butside.Text = "Add Sidekick";
            this.butside.UseVisualStyleBackColor = true;
            // 
            // herobox
            // 
            this.herobox.FormattingEnabled = true;
            this.herobox.Location = new System.Drawing.Point(155, 32);
            this.herobox.Name = "herobox";
            this.herobox.Size = new System.Drawing.Size(120, 147);
            this.herobox.TabIndex = 8;
            // 
            // vilbox
            // 
            this.vilbox.FormattingEnabled = true;
            this.vilbox.Location = new System.Drawing.Point(291, 32);
            this.vilbox.Name = "vilbox";
            this.vilbox.Size = new System.Drawing.Size(120, 147);
            this.vilbox.TabIndex = 9;
            // 
            // sidebox
            // 
            this.sidebox.FormattingEnabled = true;
            this.sidebox.Location = new System.Drawing.Point(155, 185);
            this.sidebox.Name = "sidebox";
            this.sidebox.Size = new System.Drawing.Size(120, 147);
            this.sidebox.TabIndex = 10;
            // 
            // minbox
            // 
            this.minbox.FormattingEnabled = true;
            this.minbox.Location = new System.Drawing.Point(291, 185);
            this.minbox.Name = "minbox";
            this.minbox.Size = new System.Drawing.Size(120, 147);
            this.minbox.TabIndex = 11;
            // 
            // banaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 365);
            this.Controls.Add(this.minbox);
            this.Controls.Add(this.sidebox);
            this.Controls.Add(this.vilbox);
            this.Controls.Add(this.herobox);
            this.Controls.Add(this.butside);
            this.Controls.Add(this.bitmin);
            this.Controls.Add(this.butvil);
            this.Controls.Add(this.txtside);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtvil);
            this.Controls.Add(this.txthero);
            this.Controls.Add(this.buthero);
            this.Name = "banaan";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buthero;
        private System.Windows.Forms.TextBox txthero;
        private System.Windows.Forms.TextBox txtvil;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtside;
        private System.Windows.Forms.Button butvil;
        private System.Windows.Forms.Button bitmin;
        private System.Windows.Forms.Button butside;
        private System.Windows.Forms.ListBox herobox;
        private System.Windows.Forms.ListBox vilbox;
        private System.Windows.Forms.ListBox sidebox;
        private System.Windows.Forms.ListBox minbox;
    }
}

