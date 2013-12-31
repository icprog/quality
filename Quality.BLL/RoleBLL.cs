using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using Quality.Utility;
using System.Data.SqlClient;
using System.Data;
namespace Quality.BLL
{
    public class RoleBLL
    {
        private IRole dll = new Quality.DAL.RoleDAL(new DBManager().ConnectString);
        public IList<Roles> GetAllRoles()
        {
            return dll.GetAllRoles();
        }
        public DataTable GetRoleDropDown()
        {
            return dll.GetRoleDropDown().Tables[0];
        }
        public Roles GetRoleById(int id)
        {
            return dll.GetRoleById(id);
        }
        public bool Check(string roleName)
        {
            Roles role = dll.GetRoleByName(roleName);
            if (role != null)
                return false;
            else return true;
        }
        public bool AddRole(Roles role)
        {
            return dll.AddRole(role);
        }
        public bool UpdateRole(Roles role)
        {
            return dll.UpdateRole(role);
        }
        public bool DeleteRole(int id)
        {
            return dll.DeleteRoleById(id);
        }
    }
}
