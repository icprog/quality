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
    }
}
