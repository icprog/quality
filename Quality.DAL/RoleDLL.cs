using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.Model;
using Quality.IDAL;
using Quality.Utility;
using System.Data.SqlClient;
using System.Data;
namespace Quality.DAL
{
    public class RoleDLL:IRole
    {
        private readonly string SQL_SELECT_ALLROLE = "SP_GetAllRoles";

        private string _connectString;
        public RoleDLL(string con)
        {
            _connectString = con;
        }
        public IList<Roles> GetAllRoles()
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_ALLROLE))
            {
                IList<Roles> roles = new List<Roles>();
                while (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    Roles role = new Roles(rdr.GetInt32(0), rdr.GetString(1),  rdr.GetString(2));
                    roles.Add(role);
                }

                return roles;
            }
        }


        public DataSet GetRoleDropDown()
        {
            return SqlHelper.ExecuteDataSet(_connectString, CommandType.StoredProcedure, SQL_SELECT_ALLROLE);
            
        }
    }
}
