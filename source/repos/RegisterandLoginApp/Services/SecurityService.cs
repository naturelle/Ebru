using RegisterandLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterandLoginApp.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();
        UsersDAO usersDAO = new UsersDAO();

        //construction için ctor yaz tab 
        public SecurityService()
        {
            //knownUsers.Add(new UserModel { Id = 0, UserName = "BillGates", Password = "bigbucks" });
            //knownUsers.Add(new UserModel { Id = 1, UserName = "Marie", Password = "radioactive" });
            //knownUsers.Add(new UserModel { Id = 2, UserName = "Alexander", Password = "penisilin" });
            //knownUsers.Add(new UserModel { Id = 3, UserName = "Ebru", Password = "Ekici" });
        }

        public bool isValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
           // return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
