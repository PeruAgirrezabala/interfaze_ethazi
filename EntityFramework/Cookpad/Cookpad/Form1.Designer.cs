namespace Cookpad
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userControl11 = new CookpadDll.UserControl1();
            this.tag1 = new System.Windows.Forms.Label();
            this.tag2 = new System.Windows.Forms.Label();
            this.izenatxt = new System.Windows.Forms.TextBox();
            this.emailatxt = new System.Windows.Forms.TextBox();
            this.ezizenatxt = new System.Windows.Forms.TextBox();
            this.errezetatxt = new System.Windows.Forms.TextBox();
            this.nantxt = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.comboBox1.Location = new System.Drawing.Point(818, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(4, 113);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(758, 379);
            this.userControl11.TabIndex = 3;
            // 
            // tag1
            // 
            this.tag1.AutoSize = true;
            this.tag1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag1.ForeColor = System.Drawing.Color.Brown;
            this.tag1.Location = new System.Drawing.Point(823, 42);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(185, 22);
            this.tag1.TabIndex = 4;
            this.tag1.Text = "Aukeratu ezazu urtea:";
            this.tag1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tag2
            // 
            this.tag2.AutoSize = true;
            this.tag2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag2.ForeColor = System.Drawing.Color.Brown;
            this.tag2.Location = new System.Drawing.Point(815, 221);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(208, 22);
            this.tag2.TabIndex = 5;
            this.tag2.Text = "Eman ezazu zeure botoa:";
            // 
            // izenatxt
            // 
            this.izenatxt.Location = new System.Drawing.Point(851, 304);
            this.izenatxt.Name = "izenatxt";
            this.izenatxt.Size = new System.Drawing.Size(100, 20);
            this.izenatxt.TabIndex = 6;
            // 
            // emailatxt
            // 
            this.emailatxt.Location = new System.Drawing.Point(851, 341);
            this.emailatxt.Name = "emailatxt";
            this.emailatxt.Size = new System.Drawing.Size(100, 20);
            this.emailatxt.TabIndex = 7;
            // 
            // ezizenatxt
            // 
            this.ezizenatxt.Location = new System.Drawing.Point(851, 382);
            this.ezizenatxt.Name = "ezizenatxt";
            this.ezizenatxt.Size = new System.Drawing.Size(100, 20);
            this.ezizenatxt.TabIndex = 8;
            // 
            // errezetatxt
            // 
            this.errezetatxt.Location = new System.Drawing.Point(851, 424);
            this.errezetatxt.Name = "errezetatxt";
            this.errezetatxt.Size = new System.Drawing.Size(100, 20);
            this.errezetatxt.TabIndex = 9;
            // 
            // nantxt
            // 
            this.nantxt.Location = new System.Drawing.Point(851, 268);
            this.nantxt.Name = "nantxt";
            this.nantxt.Size = new System.Drawing.Size(100, 20);
            this.nantxt.TabIndex = 10;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.Brown;
            this.sendbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.Color.White;
            this.sendbtn.Location = new System.Drawing.Point(818, 502);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(167, 53);
            this.sendbtn.TabIndex = 11;
            this.sendbtn.Text = "Botoa Bidali";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(768, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nan:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(768, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Izena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(768, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Emaila:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(768, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ezizena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(768, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Errezeta Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 638);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.nantxt);
            this.Controls.Add(this.errezetatxt);
            this.Controls.Add(this.ezizenatxt);
            this.Controls.Add(this.emailatxt);
            this.Controls.Add(this.izenatxt);
            this.Controls.Add(this.tag2);
            this.Controls.Add(this.tag1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private CookpadDll.UserControl1 userControl11;
        private System.Windows.Forms.Label tag1;
        private System.Windows.Forms.Label tag2;
        private System.Windows.Forms.TextBox izenatxt;
        private System.Windows.Forms.TextBox emailatxt;
        private System.Windows.Forms.TextBox ezizenatxt;
        private System.Windows.Forms.TextBox errezetatxt;
        private System.Windows.Forms.TextBox nantxt;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

