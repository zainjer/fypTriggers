namespace WindowsFormsApp1
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
            this.upbtn = new System.Windows.Forms.Button();
            this.downbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.rightbtn = new System.Windows.Forms.Button();
            this.Speedtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // upbtn
            // 
            this.upbtn.Location = new System.Drawing.Point(39, 2);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(75, 23);
            this.upbtn.TabIndex = 0;
            this.upbtn.Text = "up";
            this.upbtn.UseVisualStyleBackColor = true;
            this.upbtn.Click += new System.EventHandler(this.upbtn_Click);
            // 
            // downbtn
            // 
            this.downbtn.Location = new System.Drawing.Point(39, 51);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(75, 23);
            this.downbtn.TabIndex = 1;
            this.downbtn.Text = "down";
            this.downbtn.UseVisualStyleBackColor = true;
            this.downbtn.Click += new System.EventHandler(this.downbtn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.Location = new System.Drawing.Point(0, 22);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(75, 23);
            this.leftbtn.TabIndex = 2;
            this.leftbtn.Text = "left";
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // rightbtn
            // 
            this.rightbtn.Location = new System.Drawing.Point(81, 22);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(75, 23);
            this.rightbtn.TabIndex = 3;
            this.rightbtn.Text = "right";
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // Speedtb
            // 
            this.Speedtb.Enabled = false;
            this.Speedtb.Location = new System.Drawing.Point(24, 80);
            this.Speedtb.Name = "Speedtb";
            this.Speedtb.Size = new System.Drawing.Size(100, 20);
            this.Speedtb.TabIndex = 4;
            this.Speedtb.TextChanged += new System.EventHandler(this.Speedtb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 173);
            this.Controls.Add(this.Speedtb);
            this.Controls.Add(this.rightbtn);
            this.Controls.Add(this.leftbtn);
            this.Controls.Add(this.downbtn);
            this.Controls.Add(this.upbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.Button downbtn;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.TextBox Speedtb;
    }
}

