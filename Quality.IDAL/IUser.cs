using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.Model;
namespace Quality.IDAL
{
    public interface IUser
    {
        IList<Users> GetUsersByRealname(string realname);
        Users GetUserById(int id);
        bool DeleteUserById(int id);
        bool CheckUsername(string username);
        bool InsertUser(Users user);
        
    }
}
