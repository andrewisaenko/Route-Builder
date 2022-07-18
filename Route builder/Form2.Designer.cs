
namespace Route_builder
{
    partial class Form2
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
            this.CPnumberTB = new System.Windows.Forms.TextBox();
            this.setCPnumber_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPnumberTB
            // 
            this.CPnumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPnumberTB.Location = new System.Drawing.Point(5, 5);
            this.CPnumberTB.Name = "CPnumberTB";
            this.CPnumberTB.Size = new System.Drawing.Size(100, 22);
            this.CPnumberTB.TabIndex = 0;
            this.CPnumberTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.setCPnumber_but_KeyDown);
            // 
            // setCPnumber_but
            // 
            this.setCPnumber_but.Location = new System.Drawing.Point(131, 5);
            this.setCPnumber_but.Name = "setCPnumber_but";
            this.setCPnumber_but.Size = new System.Drawing.Size(75, 23);
            this.setCPnumber_but.TabIndex = 1;
            this.setCPnumber_but.Text = "OK";
            this.setCPnumber_but.UseVisualStyleBackColor = true;
            this.setCPnumber_but.Click += new System.EventHandler(this.button1_Click);
            this.setCPnumber_but.KeyDown += new System.Windows.Forms.KeyEventHandler(this.setCPnumber_but_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 35);
            this.Controls.Add(this.setCPnumber_but);
            this.Controls.Add(this.CPnumberTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setCPnumber_but;
        private System.Windows.Forms.TextBox CPnumberTB;
    }
}