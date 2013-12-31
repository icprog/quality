using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Quality.Utility
{

    public class DBManager
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

            _ipAddr = ConfigurationManager.AppSettings["sqlServerIPAddress"].ToString();
            _port = ConfigurationManager.AppSettings["sqlServerPort"].ToString();
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
        public DBManager(string ip, string port, string username, string password)
        {
            _ipAddr = ip;
            _port = port;
            _username = username;
            _encryptPassword = SysUtil.EncryptDES(password, password);
            _connectString = GetDBConnectionString();
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
        public string GetDBConnectionString()
        {
            string decryptedPassword = SysUtil.DecryptDES(_encryptPassword, "quality");
            return string.Format(@"Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog=qualityDB;User ID={2};Password={3};", _ipAddr, _port, _username, decryptedPassword);
        }
       
      



    }
}
