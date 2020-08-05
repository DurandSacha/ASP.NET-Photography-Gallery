using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Photography_Gallery.Context;

namespace Photography_Gallery.Models
{
    //[Table("User")]
    public class User
    {
        public int id { get; set; }
        [Required /*, MaxLength(20) */]
        public string Nom { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class Users
    {
    }

    public interface IDal : IDisposable
    {
    }

    public class Dal : IDal
    {
        public BddContext bdd = new BddContext();

        public void CreateOneUser(string Nom, string Email, string Password)
        {
            bdd.User.Add(new User { Nom = Nom, Email = Email, Password = Password });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

