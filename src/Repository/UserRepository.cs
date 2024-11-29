using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var docRef = _firestoreDb.Collection(CollectionName).Document(user.Id);
            docRef.SetAsync(user).Wait();
        }

        public User GetUserByName(string username)
        {
            return null;
        }

        public User GetUserById(string username)
        {
            return null;
        }

        public void UpdateUser(User user)
        {

        }

        public void DeleteUser(User user) 
        {
        
        }
    }
}
