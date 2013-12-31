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
    public class AutoCompleteBLL
    {
        private IAutoComplete dal = new Quality.DAL.AutoCompleteDAL(new DBManager().ConnectString);
        public string[] GetInstNameList()
        {
            IList<string> list=dal.GetAutoCompleteByType("inst");
            string[] val = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                val[i] = list[i];
            }
            return val;
        }
        public string[] GetMadeByList()
        {
            IList<string> list = dal.GetAutoCompleteByType("madeby");
            string[] val = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                val[i] = list[i];
            }
            return val;
        }
        public string[] GetAccordingList()
        {
            IList<string> list = dal.GetAutoCompleteByType("according");
            string[] val = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                val[i] = list[i];
            }
            return val;
        }
        public string[] GetUsedLicense()
        {
            IList<string> list = dal.GetAutoCompleteByType("license");
            string[] val = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                val[i] = list[i];
            }
            return val;
        }
        public void AddAutoComplete(string name, string type)
        {
            dal.AddAutoComplete(name, type);
        }

    }
}
