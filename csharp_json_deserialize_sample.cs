using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyApp
{

    class UserResp {
        public bool ok { get; set; }
        public string data { get; set; }

    }
    class UserRole { 
        public string r { get; set; }
        public string c { get; set; }
        public string d { get; set; }
    }
    class UserInfo {
        /*
         
         "id": "1",
        "name": "MARJON M. CAJOCON",
        "uname": "admin",
        "upass": "",
        "datecreated": "2024-02-03 13:48:00",
        "role": "1",
        "status": "1",
        "position": "",
        "token": "",
        "role_json"*/
        public string id { get; set; }
        public string name { get; set; }    
        public string uname { get; set; }
        public string upass { get; set; }
        public string datecreated { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string position { get; set; }
        public string token { get; set; }
        public UserRole[] role_json { get; set; }

    }
    class UserResp2 {
        public bool ok { get; set; }
        public UserInfo data { get; set; }
    }

    class User { 
        public string uname { get; set; }
        public string upass { get; set; }
    }

    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private async void signin_Click(object sender, EventArgs e)
        {

            var input = new User();
            input.uname = username.Text;
            input.upass = password.Text;

            var payload = JsonSerializer.Serialize<User>(input);
            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Auth", "lbkiefUs1wAPNzYf-uLVU6ma3rGBFhMOz");
            
            var res = await client.PostAsync("http://localhost:5000/api/user/signin", content);

            var resp = await res.Content.ReadAsStringAsync();
            try
            {
                var obj = JsonSerializer.Deserialize<UserResp>(resp);

                if (obj.ok)
                {
                    MessageBox.Show(obj.data);
                }
                else
                {
                    MessageBox.Show(obj.data);
                }
            }
            catch (Exception er) {

                try
                {
                    var obj = JsonSerializer.Deserialize<UserResp2>(resp);

                    if (obj.ok)
                    {
                        MessageBox.Show(obj.data.token);
                    }
                    else
                    {
                        MessageBox.Show(obj.data.name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); 
                }
            }

        }
    }
}
