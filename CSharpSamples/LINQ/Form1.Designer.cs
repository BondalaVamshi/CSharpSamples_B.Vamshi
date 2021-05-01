
namespace LINQ
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
            this.ShowValues = new System.Windows.Forms.Button();
            this.AscVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowValues
            // 
            this.ShowValues.Location = new System.Drawing.Point(251, 128);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(111, 45);
            this.ShowValues.TabIndex = 0;
            this.ShowValues.Text = "&Show";
            this.ShowValues.UseVisualStyleBackColor = true;
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // AscVal
            // 
            this.AscVal.Location = new System.Drawing.Point(515, 128);
            this.AscVal.Name = "AscVal";
            this.AscVal.Size = new System.Drawing.Size(116, 45);
            this.AscVal.TabIndex = 1;
            this.AscVal.Text = "AscendingValues";
            this.AscVal.UseVisualStyleBackColor = true;
            this.AscVal.Click += new System.EventHandler(this.AscVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AscVal);
            this.Controls.Add(this.ShowValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowValues;
        private System.Windows.Forms.Button AscVal;
    }
}

