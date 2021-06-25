using API_AutoMapperExample.Models;
using System.Collections.Generic;

namespace API_AutoMapperExample.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetUsers()
        {
            return new List<User>
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
        }
    }
}


