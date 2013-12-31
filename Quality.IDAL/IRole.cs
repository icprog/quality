using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Quality.Model;
namespace Quality.IDAL
{
    public interface IRole
    {
        IList<Roles> GetAllRoles();
        DataSet GetRoleDropDown();
        Roles GetRoleById(int id);
        Roles GetRoleByName(string name);
        bool AddRole(Roles role);
        bool DeleteRoleById(int id);
        bool UpdateRole(Roles role);
    }
}
