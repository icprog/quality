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
    public class SettingBLL
    {
        private ISetting dll =new  Quality.DAL.SettingDAL(new DBManager().ConnectString);
        public Settings GetDefaultSetting()
        {
            return dll.GetDefaultSetting();
        }
        public DataSet GetSettingDropdown()
        {
            return dll.GetSettingDropDwon();
        }
        public Settings GetSettingById(int id)
        {
            return dll.GetSettingbyId(id);
        }
        public bool UpdateSetting(Settings setting)
        {
            return dll.UpdateSetting(setting);
        }
        public bool AddSetting(Settings setting)
        {
            return dll.AddSetting(setting);
        }
        public void SetDefalut(int id)
        {
            dll.SetDefaultById(id);
        }
        public bool DeleteSettingById(int id)
        {
            return dll.DeleteSettingById(id);
        }
    }
}
