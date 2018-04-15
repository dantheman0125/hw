namespace week_3
{
    partial class Form
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
            this.AddBut = new System.Windows.Forms.Button();
            this.inputtxt = new System.Windows.Forms.TextBox();
            this.PopBut = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(219, 40);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(96, 23);
            this.AddBut.TabIndex = 0;
            this.AddBut.Text = "Add to Stack";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // inputtxt
            // 
            this.inputtxt.Location = new System.Drawing.Point(27, 42);
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(154, 20);
            this.inputtxt.TabIndex = 1;
            // 
            // PopBut
            // 
            this.PopBut.Location = new System.Drawing.Point(27, 101);
            this.PopBut.Name = "PopBut";
            this.PopBut.Size = new System.Drawing.Size(109, 23);
            this.PopBut.TabIndex = 3;
            this.PopBut.Text = "Get your last input";
            this.PopBut.UseVisualStyleBackColor = true;
            this.PopBut.Click += new System.EventHandler(this.PopBut_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(164, 106);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Last input: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 179);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PopBut);
            this.Controls.Add(this.inputtxt);
            this.Controls.Add(this.AddBut);
            this.Name = "Form";
            this.Text = "Stack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.TextBox inputtxt;
        private System.Windows.Forms.Button PopBut;
        private System.Windows.Forms.Label label;
    }
}

