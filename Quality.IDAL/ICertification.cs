using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.Model;
namespace Quality.IDAL
{
    public interface ICertification
    {
        bool AddCertification(Certification certification);
        Certification GetCertificationById(int id);
        Certification GetCertificationBySerial(string SerialNo);
        IList<Certification> GetAllCertifications();
        IList<Certification> GetCertificationsByCondition(string range,string keyword,DateTime dateRange1,DateTime dateRange2,string type,DateTime expire1,DateTime expire2);
        void PrintOnce(string SerialNo);
    }
}
