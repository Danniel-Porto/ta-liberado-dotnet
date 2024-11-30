using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ta_liberado
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty(nameof(Username))]
        public string Username { get; set; }
        [FirestoreProperty(nameof(Password))]
        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
