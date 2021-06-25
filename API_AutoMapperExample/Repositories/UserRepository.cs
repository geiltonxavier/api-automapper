using API_AutoMapperExample.Models;
using System.Collections.Generic;

namespace API_AutoMapperExample.Repositories
{
    public class UserRepository : IUserRepository
    {
        List<User> usersDB = new List<User>()
        {
            new User()
                {
                    Name = "John",
                    LastName = "Due",
                    Age = 32,
                    Gender = "Masculino",
                    Address = new Address()
                    {
                        City = "São Paulo",
                        Number = 10,
                        State = "SP",
                        PostalCode = "999999"
                    }
                }
         };

        public UserRepository()
        {

        }

        public List<User> GetUsers()
        {
            return usersDB;
        }


        public void Create(User user)
        {
            usersDB.Add(user);
        }

    }
}


