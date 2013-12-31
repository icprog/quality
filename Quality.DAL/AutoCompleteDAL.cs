using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using Quality.Utility;
using System.Data.SqlClient;
using System.Data;
namespace Quality.DAL
{
    public class AutoCompleteDAL:IAutoComplete
    {
        private string _connectString;
        private readonly string SQL_SELECT_AUTOCOMPLETEBYTYPE = "SP_GetAutoCompleteListByType";
        private readonly string SQL_INSERT_AUTOCOMPLETE = "SP_AddAutoComplete";
        public AutoCompleteDAL(string con)
        {
            _connectString = con;
        }
        public IList<string> GetAutoCompleteByType(string type)
        {
            
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_AUTOCOMPLETEBYTYPE,new SqlParameter("TYPE",type)))
            {
                IList<string> list=new List<string>();
                while (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    string name = rdr.GetString(0);
                    list.Add(name);
                }

                return list;
            }
        }


        public void AddAutoComplete(string name, string type)
        {
            SqlParameter[] parms =
            {
                 new SqlParameter("NAME", name),
                 new SqlParameter("TYPE",type)
            };
            SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_INSERT_AUTOCOMPLETE, parms);
        }
    }
}
