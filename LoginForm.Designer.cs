namespace VK_API_Tutorial
{
    partial class LoginForm
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
            this.loginBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // loginBrowser
            // 
            this.loginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBrowser.Location = new System.Drawing.Point(0, 0);
            this.loginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginBrowser.Name = "loginBrowser";
            this.loginBrowser.Size = new System.Drawing.Size(621, 700);
            this.loginBrowser.TabIndex = 0;
            this.loginBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.loginBrowser_DocumentCompleted);
            this.loginBrowser.LocationChanged += new System.EventHandler(this.loginBrowser_LocationChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 700);
            this.Controls.Add(this.loginBrowser);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser loginBrowser;
    }
}