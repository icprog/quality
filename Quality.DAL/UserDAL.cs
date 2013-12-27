using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using System.Data.SqlClient;
using System.Data;
using Quality.Utility;
namespace Quality.DAL
{
    public class UserDAL:IUser
    {
        private readonly string SQL_SELECT_USERSBYREALNAME = "SP_GetUserListByRealname";
        private readonly string SQL_SELECT_USERBYID = "SP_GetUsersById";
        private readonly string SQL_DELETE_USERBYID = "SP_DeleteUserById";
        private readonly string SQL_SELECT_USERCHECKUSERNAME = "SP_CheckUsername";
        private readonly string SQL_INSERT_USER = "SP_InsertUser";
        private string _connectString;
        public UserDAL(string connStr)
        {
            _connectString = connStr;
        }
        public IList<Users> GetUsersByRealname(string realname)
        {
            
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_USERSBYREALNAME,new SqlParameter("realname",realname)))
            {
                IList<Users> Users = new List<Users>();
                while (rdr.Read())
                {
                  //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    Users user = new Users(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5));
                    Users.Add(user);
                }
            
            return Users;
            }
        }


        public Users GetUserById(int id)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_USERBYID, new SqlParameter("USERID", id)))
            {
                Users user=new Users();
                
                if (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    user = new Users(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5));
                  
                }

                return user;
            }
        }


        public bool DeleteUserById(int id)
        {
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_DELETE_USERBYID, new SqlParameter("USERID", id));
            if (result == 1)
            {
                return true;
            }
            else return false;
        }


        public bool CheckUsername(string username)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_USERCHECKUSERNAME, new SqlParameter("USERNAME", username)))
            {


                if (rdr.Read())
                {
                    return false;
                }
                else
                    return true;
               
            } 
        }


        public bool InsertUser(Users user)
        {
            SqlParameter[] parms=
            {
                new SqlParameter("USERNAME",user.Username),
                new SqlParameter("PASSWORD",user.Password),
                new SqlParameter("REALNAME",user.Realname),
                new SqlParameter("ROLEID",user.RoleId)};
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_INSERT_USER, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;

        }
    }
}
