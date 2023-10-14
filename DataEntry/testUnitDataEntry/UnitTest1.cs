using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataEntry.Repository.Repositories;
using DataEntry.ModelsEntity;
using DataEntry.Interfaces;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTestAddEntry
    {
        [TestMethod]

      // Create an instance of UserRepository

        public void TestAddUser_NoExceptions()
        {
            // Crear una instancia de UserRepository
            var userRepository = new UserRepository();

            // Create a new user with test data
            var newUser = new UserEntity
            {
                FirstName = "Brian",
                LastName = "Martinez",
                Age = 32,
                Email = "brianmarti@gmail.com.com",
                Password = "contraseņa123456"
            };

            // Call the Add method in UserRepository

            userRepository.Add(newUser);
        }
    }                                       
}
            // Thanks to this test we make sure that the method we will use to add new users works correctly as expected.
                            