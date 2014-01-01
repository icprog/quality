using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Quality.Model;
namespace Quality.IDAL
{
    public interface ISetting
    {
        Settings GetDefaultSetting();
        DataSet GetSettingDropDwon();
        Settings GetSettingbyId(int id);
        bool AddSetting(Settings setting);
        bool UpdateSetting(Settings setting);
        bool DeleteSettingById(int id);
        void SetDefaultById(int id);

    }
}
