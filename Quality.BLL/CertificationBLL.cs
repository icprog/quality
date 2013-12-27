using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using Quality.Utility;
namespace Quality.BLL
{
    public class CertificationBLL
    {
        ICertification dal = new Quality.DAL.CertificationDAL(new DBManager().ConnectString);
        public IList<Certification> GetAllCertifications()
        {
            return dal.GetAllCertifications();
        }
        public IList<Certification> GetCertificationsBySearch(string keyword, string range, string type, DateTime start, DateTime end, DateTime expire1,DateTime expire2)
        {
            if(start==DateTime.Parse("0001/1/1 0:00:00"))
            {
                start = DateTime.Parse("1900/1/1 0:00:00");
            }
            if(end==DateTime.Parse("0001/1/1 0:00:00"))
            {
                end = DateTime.Now;
            }
            if (expire2 ==DateTime.Parse("0001/1/1 0:00:00"))
            {
                expire2=DateTime.Parse("2999/12/31 23:59:59");

            }
            if (expire1 == DateTime.Parse("0001/1/1 0:00:00"))
            {
                expire1 = DateTime.Parse("1900/1/1 0:00:00");

            }
            if (string.IsNullOrEmpty(range))
            {
                range = "全部";
            }
            if (string.IsNullOrEmpty(type))
            {
                type = "全部";
            }

           return  dal.GetCertificationsByCondition(range, keyword, start, end, type, expire1, expire2);
            
        }

    }
}
