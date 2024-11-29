using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ta_liberado;

public interface IUserRepository
{
    void AddUser(User user);

    User GetUserByName(string username);

    User GetUserById(string username);

    void UpdateUser(User user);

    void DeleteUser(User user);
}
