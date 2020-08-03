using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Photography_Gallery.Models
{
    [Table("User")]
    public class User
    {
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string Nom { get; set; }
        [Required]
        public string Email { get; set; }
    }

    public class Users
    {
        private BddContext bdd;

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

        public void CreateOneUser(string nom, string email)
        {
            bdd.User.Add(new User { Nom = nom, Email = email });
            bdd.SaveChanges();
        }

        public User GetOneUser(int id)
        {
            return bdd.User.FirstOrDefault(u => u.id == id);
        }

        /*
        public void EditUser(int id, string nom, string email)
        {
            user userFind = bdd.Users.FirstOrDefault(user => user.Id == id);
            if ( userFind != null)
            {
                userFind.Nom = nom;
                userFind.Email = email;
                bdd.SaveChanges();
            }
        }
        */

        public void CreateFourUserFixtures()
        {
            bdd.User.Add(new User { id = 1, Nom = "Sacha", Email = "sacha6623@gmail.com" });
            bdd.User.Add(new User { id = 2, Nom = "Yohann", Email = "Yohanndurand76@gmail.com" });
            bdd.User.Add(new User { id = 3, Nom = "User1", Email = "user1@outlook.com" });
            bdd.User.Add(new User { id = 4, Nom = "User2", Email = "user2@outlook.com" });
    
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }


    public class BddContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public System.Data.Entity.DbSet<Photography_Gallery.Models.Photography> Photographies { get; set; }
    }

}

