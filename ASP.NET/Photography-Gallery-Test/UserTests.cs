using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Photography_Gallery_Test
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestUserIsDefinedWithCreateUserMethod()

            // Init DB 
            /*
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            */
        {
            /*
            using (IDal dal = new Dal())
            {
                dal.CreateOneUser("Durand", "sacha6623@gmail.com");
                List<User> user = dal.ObtientTousLesRestaurants();

                Assert.IsNotNull(user);
                Assert.AreEqual(1, user.Count);
                Assert.AreEqual("La bonne fourchette", user[0].Nom);
                Assert.AreEqual("01 02 03 04 05", user[0].Telephone);
            }
            */
        }
    }
}
