using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.Model;
using Quality.IDAL;
using Quality.Utility;
using System.Data.SqlClient;
using System.Data;
namespace Quality.DAL
{
    public class SettingDAL:ISetting
    {
        private string SQL_SELECT_DEFALUTSETTING = "SP_LoadDefaultSetting";
        private string SQL_SELECT_ALLSETTINGS = "SP_GetAllSettings";
        private string SQL_SELECT_SETTINGBYID = "SP_GetSettingById";
        private string SQL_UPDATE_SETTING = "SP_UpdateSetting";
        private string SQL_INSERT_SETTING = "SP_AddSetting";
        private string SQL_UPDATE_SETDEFAULT = "SP_SetSettingDefault";
        private string SQL_DELETE_SETTINGBYID = "SP_DeleteSettingById";
        private string _connectString;
        public SettingDAL(string con)
        {
            _connectString = con;
        }
        public Settings GetDefaultSetting()
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_DEFALUTSETTING))
            {
                Settings setting;
                if (rdr.Read())
                {

                    setting = new Settings(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8),
                        rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetInt32(13));
                }
                else setting = null;
                return setting;
            }
        }


        public DataSet GetSettingDropDwon()
        {
            return SqlHelper.ExecuteDataSet(_connectString, CommandType.StoredProcedure, SQL_SELECT_ALLSETTINGS);
        }

        public bool AddSetting(Settings setting)
        {
            SqlParameter[] parms =
            {
               
                 new SqlParameter("SETTING_NAME",setting.SettingName),
                  new SqlParameter("UNITCHS",setting.AuthUnitChs),
                   new SqlParameter("UNITENG",setting.AuthUnitEng),
                    new SqlParameter("ADDRCHS",setting.AddrChs),
                     new SqlParameter("ADDRENG",setting.AddrEng),
                      new SqlParameter("EMAIL",setting.Email),
            new SqlParameter("FAX",setting.Fax),
                  new SqlParameter("VERIFICATION",setting.VerificationNo),
                  new SqlParameter("STANDARD1",setting.Standard1),
                   new SqlParameter("STANDARD2",setting.Standard2),
                    new SqlParameter("TELEPHONE",setting.Telephone),
                     new SqlParameter("ZIPCODE",setting.Zipcode),
                      new SqlParameter("DEFAULT",setting.IsUse)
               
               };
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure,SQL_INSERT_SETTING, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateSetting(Settings setting)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("ID",setting.Id),
                 new SqlParameter("SETTING_NAME",setting.SettingName),
                  new SqlParameter("UNITCHS",setting.AuthUnitChs),
                   new SqlParameter("UNITENG",setting.AuthUnitEng),
                    new SqlParameter("ADDRCHS",setting.AddrChs),
                     new SqlParameter("ADDRENG",setting.AddrEng),
                      new SqlParameter("EMAIL",setting.Email),
            new SqlParameter("FAX",setting.Fax),
                  new SqlParameter("VERIFICATION",setting.VerificationNo),
                  new SqlParameter("STANDARD1",setting.Standard1),
                   new SqlParameter("STANDARD2",setting.Standard2),
                    new SqlParameter("TELEPHONE",setting.Telephone),
                     new SqlParameter("ZIPCODE",setting.Zipcode),
                      new SqlParameter("DEFAULT",setting.IsUse)
               
               };
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_UPDATE_SETTING, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
        }

        public bool DeleteSettingById(int id)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("ID",id)
               };
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_DELETE_SETTINGBYID, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
        }

        public void SetDefaultById(int id)
        {

             SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_UPDATE_SETDEFAULT, new SqlParameter("ID", id));
            
        }


        public Settings GetSettingbyId(int id)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_SETTINGBYID,new SqlParameter("ID",id)))
            {
                Settings setting;
                if (rdr.Read())
                {

                    setting = new Settings(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8),
                        rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetInt32(13));
                }
                else setting = null;
                return setting;
            }
        }


       
    }
}
