using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    [Serializable]
    public class Users
    {
        #region //成员变量
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int roleId;

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        private string roleName;

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }

        }
        private string roleValue;

        public string RoleValue
        {
            get { return roleValue; }
            set { roleValue = value; }
        }
        private string realname;

        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }
        #endregion
        #region //构造函数
        public Users(string username, string password, int roleId, string roleName,string realname)
        {
            this.username = username;
            this.password = password;
            this.roleId = roleId;
            this.roleName = roleName;
            this.realname = realname;

        }
        public Users(int id, string username, int roleId, string roleName, string roleValue,string realname)
        {
            this.id = id;
            this.username = username;
            this.roleId = roleId;
            this.roleName = roleName;
            this.roleValue = roleValue;
            this.realname = realname;
        }
        public Users()
        {
        }
        public Users(string username, int roleId, string password, string realname)
        {
            this.username = username;
            this.roleId = roleId;
            this.password = password;
            this.realname = realname;
        }
        #endregion
    }
}
