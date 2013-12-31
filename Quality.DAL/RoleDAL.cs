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
    public class RoleDAL:IRole
    {
        private readonly string SQL_SELECT_ALLROLE = "SP_GetAllRoles";
        private readonly string SQL_SELECT_ROLEBYID = "SP_GetRoleById";
        private readonly string SQL_SELECT_ROLEBYNAME = "SP_GetRoleByName";
        private readonly string SQL_INSERT_ROLE = "SP_AddRoles";
        private readonly string SQL_UPDATE_ROLEBYID="SP_UpdateRoleById";
        private readonly string SQL_DELETE_ROLEBYID = "SP_DeleteRoleById";
        private readonly string SQL_SELECT_ROLEDROPDOWN = "SP_GetRoleDropDown";
        private string _connectString;
        public RoleDAL(string con)
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
            return SqlHelper.ExecuteDataSet(_connectString, CommandType.StoredProcedure, SQL_SELECT_ROLEDROPDOWN);
            
        }


        public Roles GetRoleById(int id)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_ROLEBYID,new SqlParameter("ROLEID",id)))
            {
                Roles role=new Roles();
                if (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                   ;role = new Roles(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));
                   
                }

                return role;
            }
        }

        public Roles GetRoleByName(string name)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_ROLEBYNAME, new SqlParameter("ROLENAME", name)))
            {
                Roles role;
                if (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    ; role = new Roles(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));

                }
                else role = null;
                return role;
            }
        }


        public bool AddRole(Roles role)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("ROLENAME",role.RoleName),
               
                new SqlParameter("ROLEVALUE",role.RoleValue)};
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_INSERT_ROLE, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
        }

        public bool DeleteRoleById(int id)
        {
          
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_DELETE_ROLEBYID, new SqlParameter("ROLEID",id));
            if (result == 1)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateRole(Roles role)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("ROLENAME",role.RoleName),
                new SqlParameter("ROLEID",role.Id),
                new SqlParameter("ROLEVALUE",role.RoleValue)};
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_UPDATE_ROLEBYID, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
