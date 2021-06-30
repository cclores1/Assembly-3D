using Assembly_3D.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Services
{
    public class SecurityServices
    {
      
        UsersDAO usersDAO = new UsersDAO();

        public SecurityServices()
        {
           
        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);

            
        }

    }
}
