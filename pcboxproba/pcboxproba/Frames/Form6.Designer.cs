﻿namespace pcboxproba.Frames
{
    partial class Form6
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
            this.grafikoaren_kontrola1 = new grafikoaDll.Grafikoaren_kontrola();
            this.SuspendLayout();
            // 
            // grafikoaren_kontrola1
            // 
            this.grafikoaren_kontrola1.Location = new System.Drawing.Point(37, 51);
            this.grafikoaren_kontrola1.Name = "grafikoaren_kontrola1";
            this.grafikoaren_kontrola1.Size = new System.Drawing.Size(453, 277);
            this.grafikoaren_kontrola1.TabIndex = 0;
            this.grafikoaren_kontrola1.Load += new System.EventHandler(this.grafikoaren_kontrola1_Load);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.grafikoaren_kontrola1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public grafikoaDll.Grafikoaren_kontrola grafikoaren_kontrola1;
    }
}