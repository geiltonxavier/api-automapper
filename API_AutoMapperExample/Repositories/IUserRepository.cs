using API_AutoMapperExample.Models;
using System.Collections.Generic;

namespace API_AutoMapperExample.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}