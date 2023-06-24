namespace industries_management_sysytem
{
    partial class UserControl2
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
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(224, 122);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(211, 20);
            this.user_txt.TabIndex = 0;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(224, 168);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(211, 20);
            this.pass_txt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(329, 206);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "button2";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(709, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login_btn;
    }
}
