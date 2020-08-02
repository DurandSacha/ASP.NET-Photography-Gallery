using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Photography_Gallery.Models
{
    public interface IDal : IDisposable
    {
        List<User> getAllUsers();
    }

    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        
        public List<Users> getAllUsers()
        {
            //return "GetAllUserFunction";
            //return bdd.users.GetAllUsers();
            return bdd.User.GetAllUsers();
        }
        
        
        public void Dispose()
        {
            bdd.Dispose();
        }

        List<User> IDal.getAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}


