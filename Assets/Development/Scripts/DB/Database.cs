using UnityEngine;
using Firebase.Database;

namespace Swiper
{
    public class Database : MonoBehaviour
    {
        private DatabaseReference _dbReference;

        private void Start()
        {
            _dbReference = FirebaseDatabase.DefaultInstance.RootReference;
        }

        [ContextMenu("SaveData")]
        private void SaveSomeDate()
        {
            User user = new User { Name = "Lilo", Age = 24, Email = "trt@gmail.com" };

            string userJson = JsonUtility.ToJson(user);

            _dbReference.Child("Usersss").Child(user.Name).SetRawJsonValueAsync(userJson);
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
