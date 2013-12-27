using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Quality.Model;
namespace Quality
{
   
    public  class DBManager
    {
        #region 成员变量
        private string _errorMsg;
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }
        private string _ipAddr;

        public string IpAddr
        {
            get { return _ipAddr; }
            set { _ipAddr = value; }
        }
        private string _port;

        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _encryptPassword;

        public string EncryptPassword
        {
            get { return _encryptPassword; }
            set { _encryptPassword = value; }
        }
        public bool isConnectable;
        private string _connectString;

        public string ConnectString
        {
            get { return _connectString; }
            set { _connectString = value; }
        }
        #endregion
        

        public DBManager()
        {

            _ipAddr= ConfigurationManager.AppSettings["sqlServerIPAddress"].ToString();
            _port= ConfigurationManager.AppSettings["sqlServerPort"].ToString();
            _username = ConfigurationManager.AppSettings["dbUsername"].ToString();
            _encryptPassword = ConfigurationManager.AppSettings["dbPassword"].ToString();
            _connectString = GetDBConnectionString(_ipAddr, _port, _username, _encryptPassword);
            string connectState = TestConnect();
            if (connectState == "Open")
            {
                isConnectable = true;
                _state = "Connectable";
                _errorMsg = "0";
            }
            else
            {
                isConnectable = false;
                _errorMsg = connectState;
            }
        }
        public string TestConnect()
        {

            return SqlHelper.ConnectTest(_connectString);
        }
        public static string GetDBConnectionString(string ip, string port, string username, string encrptyPassword)
        {
            string decryptedPassword = SysUtil.DecryptDES(encrptyPassword, "quality");
            return string.Format(@"Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog=qualityDB;User ID={2};Password={3};", ip, port, username, decryptedPassword);
        }
        
        public BenchSet GetBenchSet(string name)
        {

            SqlParameter[] parms ={
                                     new SqlParameter ("BENCHSET_NAME",name)
                                 };
            DataSet ds = SqlHelper.ExecuteDataSet(_connectString, CommandType.StoredProcedure, "GetBenchSetByName", parms);
            DataRow row= ds.Tables[0].Rows[0];
            //BenchSet bench = new BenchSetClass(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), DateTime.Parse(row[7].ToString()));
            return null;
          
        }
        //public bool Login(string username, string password)
        //{
        //    if ("offline" == _type)
        //    {
        //        string sql = "select * from users where username='" + username + "' and password='" + password + "'";
        //        access = new AccessDbClass(_mdbFilePath);
        //        int count = access.SelectToDataTable(sql).Rows.Count;
        //        access.Close();
        //        if (count == 1)
        //        {
        //            return true;
        //        }
        //        else if (count > 1)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public Users Login(string username, string password)
        {
            SqlParameter[] parms=
            {
                new SqlParameter("USERNAME",username),
                new SqlParameter("PASSWORD",password)
            };
            DataSet ds = SqlHelper.ExecuteDataSet(_connectString, CommandType.StoredProcedure, "SP_GetUserByLogin", parms);
           Users user;
           if (ds.Tables[0].Rows.Count > 0)
           {
               user = new Users(int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), ds.Tables[0].Rows[0]["username"].ToString(), int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString()), ds.Tables[0].Rows[0]["RoleName"].ToString(), ds.Tables[0].Rows[0]["RoleValue"].ToString(), ds.Tables[0].Rows[0]["realname"].ToString());
           }
           else
               user = null;
           return user;
        }
       
        
        
    }
}
