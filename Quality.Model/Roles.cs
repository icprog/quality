using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    public class Roles
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
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
        private int adminFlag;

        public int AdminFlag
        {
            get { return adminFlag; }
            set { adminFlag = value; }
        }

        public Roles()
        {
        }
        public Roles(int id, string rolename, string roleValue,int adminFlag)
        {
            this.id = id;
            this.roleName = rolename;
            this.roleValue = roleValue;
            this.adminFlag = adminFlag;
        }
        public Roles( string rolename, string roleValue,int adminFlag)
        {
        
            this.roleName = rolename;
            this.roleValue = roleValue;
            this.adminFlag = adminFlag;
        }
        
    }
}
