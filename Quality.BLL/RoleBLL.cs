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
        private IRole dll = new Quality.DAL.RoleDLL(new DBManager().ConnectString);
        public IList<Roles> GetAllRoles()
        {
            return dll.GetAllRoles();
        }
        public DataTable GetRoleDropDown()
        {
            return dll.GetRoleDropDown().Tables[0];
        }
        
    }
}
