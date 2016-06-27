using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_API_Tutorial
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginBrowser.Navigate("https://oauth.vk.com/authorize?client_id=5524315&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=5151&response_type=token&v=5.52");
        }

        private void loginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void loginBrowser_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                string LURL = loginBrowser.Url.ToString();
                string URL = LURL.Split('#')[1];

                if (URL[0] == 'a')
                {
                    authInfo.Default.token = URL.Split('&')[0].Split('=')[1];
                    authInfo.Default.id = URL.Split('=')[3];
                    authInfo.Default.auth = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Token Error!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
