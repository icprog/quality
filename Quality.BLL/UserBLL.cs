using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using Quality.Utility;

namespace Quality.BLL
{
   public  class UserBLL
    {
       private IUser dal = new Quality.DAL.UserDAL(new DBManager().ConnectString);
       public IList<Users> GetRealNameList(string realname)
       {
           return dal.GetUsersByRealname(realname);
       }
       public Users GetUserById(int id)
       {
           return dal.GetUserById(id);
       }
       public bool DeleteUserById(int id)
       {
           return dal.DeleteUserById(id);
       }
       public bool CheckUsername(string username)
       {
           return dal.CheckUsername(username.Trim());
       }
       public bool AddUser(Users user)
       {
           return dal.InsertUser(user);
       }
    }
}
