namespace industries_management_sysytem
{
    partial class login_frm
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
            this.usr_txt = new System.Windows.Forms.TextBox();
            this.passw_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usr_txt
            // 
            this.usr_txt.Location = new System.Drawing.Point(173, 154);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.Size = new System.Drawing.Size(185, 20);
            this.usr_txt.TabIndex = 0;
            this.usr_txt.TextChanged += new System.EventHandler(this.usr_txt_TextChanged);
            // 
            // passw_txt
            // 
            this.passw_txt.Location = new System.Drawing.Point(173, 209);
            this.passw_txt.Name = "passw_txt";
            this.passw_txt.Size = new System.Drawing.Size(185, 20);
            this.passw_txt.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(283, 253);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_clear
            // 
            this.login_clear.Location = new System.Drawing.Point(173, 253);
            this.login_clear.Name = "login_clear";
            this.login_clear.Size = new System.Drawing.Size(75, 23);
            this.login_clear.TabIndex = 3;
            this.login_clear.Text = "Clear";
            this.login_clear.UseVisualStyleBackColor = true;
            this.login_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usr_txt);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_clear);
            this.panel1.Controls.Add(this.passw_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 460);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 460);
            this.Controls.Add(this.panel1);
            this.Name = "login_frm";
            this.RightToLeftLayout = true;
            this.Text = " Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usr_txt;
        protected System.Windows.Forms.TextBox passw_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_clear;
        private System.Windows.Forms.Panel panel1;
    }
}

