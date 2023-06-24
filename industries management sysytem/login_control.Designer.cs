namespace industries_management_sysytem
{
    partial class login_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usr_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_clear = new System.Windows.Forms.Button();
            this.passw_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usr_txt
            // 
            this.usr_txt.Location = new System.Drawing.Point(205, 130);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.Size = new System.Drawing.Size(261, 20);
            this.usr_txt.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(349, 232);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_clear
            // 
            this.login_clear.Location = new System.Drawing.Point(239, 232);
            this.login_clear.Name = "login_clear";
            this.login_clear.Size = new System.Drawing.Size(75, 23);
            this.login_clear.TabIndex = 7;
            this.login_clear.Text = "Clear";
            this.login_clear.UseVisualStyleBackColor = true;
            this.login_clear.Click += new System.EventHandler(this.login_clear_Click);
            // 
            // passw_txt
            // 
            this.passw_txt.Location = new System.Drawing.Point(205, 185);
            this.passw_txt.Name = "passw_txt";
            this.passw_txt.Size = new System.Drawing.Size(261, 20);
            this.passw_txt.TabIndex = 5;
            // 
            // login_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usr_txt);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_clear);
            this.Controls.Add(this.passw_txt);
            this.Name = "login_control";
            this.Size = new System.Drawing.Size(709, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usr_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_clear;
        protected System.Windows.Forms.TextBox passw_txt;
    }
}
