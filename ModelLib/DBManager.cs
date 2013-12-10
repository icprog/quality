using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ModelLib
{
    public  class DBManager
    {
        #region 成员变量
        private AccessDbClass access;
        private string _type;
        private string _mdbFilePath = ConfigurationManager.AppSettings["mdbFilePath"].ToString();
        private string _connectionString;
        #endregion
        

        public DBManager(string type,string conn)
        {
            _type = type;
            if (type == "offline")
            {
                _mdbFilePath = conn;
            }
            else
            {
                _connectionString = conn;
            }

   
        }
        
        public BenchSetClass GetBenchSet(string name)
        {
            if ("offline" == _type)
            {
                string sql = "select * from benchSet where benchSet_name='" + name + "'";
                access = new AccessDbClass(_mdbFilePath);
                DataTable table = new DataTable();
                table = access.SelectToDataTable(sql);
                DataRow row = table.Rows[0];
                BenchSetClass bench = new BenchSetClass(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), DateTime.Parse(row[7].ToString()));
                return bench;
            }
            else
            {
                return null;
            }
        }
        
        
    }
}
