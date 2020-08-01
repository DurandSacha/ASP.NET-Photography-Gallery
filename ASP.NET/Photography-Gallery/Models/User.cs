using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Photography_Gallery.Models
{
    // https://openclassrooms.com/fr/courses/1730206-apprenez-asp-net-mvc/1828216-le-modele
    public class User
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
    }

    public class Users
    {
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User { id = 1, Nom = "Sacha", Email = "sacha6623@gmail.com"},
                new User { id = 2, Nom = "Yohann", Email = "Yohanndurand76@gmail.com"},
                new User { id = 3, Nom = "User1", Email  ="user1@outlook.com"},
                new User { id = 4, Nom = "User2", Email = "user2@outlook.com"}
            };
        }
    }
}