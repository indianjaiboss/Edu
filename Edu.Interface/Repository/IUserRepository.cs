using System;
using System.Collections.Generic;
using System.Text;
using Edu.Domain.Model;
namespace Edu.Interface.Repository
{
    public interface IUserRepository
    {
        User GetUser(string email, string password);
    }
}
