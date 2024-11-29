using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

public class FirestoreConnection
{
    private FirestoreDb _firestoreDb;

    public FirestoreConnection()
    {
        // Substitua "your-project-id" pelo ID do seu projeto Firebase
        _firestoreDb = FirestoreDb.Create("your-project-id");
    }

    public async Task AddDocumentAsync()
    {
        DocumentReference docRef = _firestoreDb.Collection("users").Document("user-id");
        Dictionary<string, object> user = new Dictionary<string, object>
        {
            { "FirstName", "John" },
            { "LastName", "Doe" },
            { "Age", 30 }
        };
        await docRef.SetAsync(user);
    }
}
