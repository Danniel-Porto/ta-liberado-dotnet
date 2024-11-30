using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ta_liberado
{
    internal class UserRepository : IUserRepository
    {
        private readonly FirestoreDb _firestoreDb;
        private const string CollectionName = "users"; // Nome da coleção de usuários no Firestore

        public UserRepository(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public void AddUser(User user)
        {
            DocumentReference docRef = _firestoreDb.Collection(CollectionName).Document(user.Username);
            docRef.SetAsync(user).Wait();
        }

        public User GetUserByName(string username)
        {
            try
            {
                DocumentSnapshot docSnapshot = _firestoreDb.Collection(CollectionName).Document(username).GetSnapshotAsync().GetAwaiter().GetResult();

                if (docSnapshot.Exists)
                {
                    return docSnapshot.ConvertTo<User>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void UpdateUser(User user)
        {

        }

        public void DeleteUser(User user) 
        {
        
        }
    }
}
