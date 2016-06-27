using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VK_API_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string userID = idBox.Text;

            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            var friendsList = new List<UserRecord>();
            var jsonAnswer = client.DownloadString("https://api.vk.com/method/users.get?user_ids=" + userID + "&fields=bdate&v=5.52");
            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonAnswer);

            UserRecord user = new UserRecord { id = data.response[0].id, firstName = data.response[0].first_name, lastName = data.response[0].last_name };
            userLabel.Text = user.userInfo;

            jsonAnswer = client.DownloadString("https://api.vk.com/method/friends.get?user_id=" + userID + "&fields=all&v=5.52");
            data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonAnswer);

            foreach (dynamic index in data.response.items)
                friendsList.Add(new UserRecord { id = index.id, firstName = index.first_name, lastName = index.last_name });      

            foreach (UserRecord index in friendsList)
                friendsListBox.Items.Add(index.userInfo);

            friendsCountLabel.Text = friendsListBox.Items.Count.ToString();

            jsonAnswer = client.DownloadString("https://api.vk.com/method/photos.get?owner_id=" + userID + "&rev=1&photo_sizes=1&album_id=profile&v=5.52");
            data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonAnswer);

            mainPhotoBox.ImageLocation =  data.response.items[0].sizes[3].src;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
