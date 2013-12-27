using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.IDAL;
using Quality.Model;
using System.Data.SqlClient;
using System.Data;
using Quality.Utility;
namespace Quality.DAL
{
    public class CertificationDAL :ICertification
    {

        private readonly string SQL_SELECT_ALLCERTIFICATION = "SP_GETALLCERTIFICATION";
        private readonly string SQL_SELECT_CERTIFICATIONBYSEARCH = "SP_GetCertificationByCondition";
        private string _connectString;
        public CertificationDAL(string connectionStr)
        {
            _connectString = connectionStr;
        }
        public bool AddCertification(Certification certification)
        {
            throw new NotImplementedException();
        }

        public Certification GetCertificationById(int id)
        {
            throw new NotImplementedException();
        }

        public Certification GetCertificationBySerial(string SerialNo)
        {
            throw new NotImplementedException();
        }

        public IList<Certification> GetAllCertifications()
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString,CommandType.StoredProcedure,SQL_SELECT_ALLCERTIFICATION))
            {
                IList<Certification> Certifications = new List<Certification>();
                while (rdr.Read())
                {
                    Certification Certification = 
                        new Certification(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetDateTime(4),rdr.GetString(5),rdr.GetString(6),rdr.GetString(7),rdr.GetString(8),rdr.GetString(9),rdr.GetString(10),rdr.GetString(11),rdr.GetString(12),rdr.GetString(13),rdr.GetDateTime(14),
                        rdr.GetString(15),rdr.GetString(16),rdr.GetString(17),rdr.GetString(18),rdr.GetString(19),rdr.GetDateTime(20),
                         rdr.GetString(21),rdr.GetString(22),rdr.GetString(23),rdr.GetString(24),rdr.GetString(25),rdr.GetDateTime(26),
                          rdr.GetString(27),rdr.GetString(28),rdr.GetString(29),rdr.GetString(30),rdr.GetString(31),rdr.GetDateTime(32),
                        rdr.GetString(33),rdr.GetString(34),rdr.GetString(35),rdr.GetString(36),rdr.GetString(37),
                        rdr.GetString(38),rdr.GetString(39),rdr.GetString(40),rdr.GetString(41),rdr.GetString(42),
                        rdr.GetString(43),rdr.GetString(44),rdr.GetString(45),rdr.GetInt32(46),rdr.GetString(47)
                        );
                    Certifications.Add(Certification);
                }
                return Certifications;
            }
        }

        public IList<Certification> GetCertificationsByCondition(string range, string keyword, DateTime dateRange1, DateTime dateRange2, string type, DateTime expire1,DateTime expire2)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("KEYWORD",keyword),
                new SqlParameter("STARTDATE", dateRange1),
                new SqlParameter("ENDDATE",dateRange2),
                new SqlParameter("CERTTYPE",type),
                new SqlParameter("RANGE",range),
                new SqlParameter("EXPIRE1",expire1),
                new SqlParameter("EXPIRE2",expire2)
            };
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_CERTIFICATIONBYSEARCH,parms))
            {
                IList<Certification> Certifications = new List<Certification>();
                while (rdr.Read())
                {
                    Certification Certification =
                        new Certification(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetDateTime(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetString(13), rdr.GetDateTime(14),
                        rdr.GetString(15), rdr.GetString(16), rdr.GetString(17), rdr.GetString(18), rdr.GetString(19), rdr.GetDateTime(20),
                         rdr.GetString(21), rdr.GetString(22), rdr.GetString(23), rdr.GetString(24), rdr.GetString(25), rdr.GetDateTime(26),
                          rdr.GetString(27), rdr.GetString(28), rdr.GetString(29), rdr.GetString(30), rdr.GetString(31), rdr.GetDateTime(32),
                        rdr.GetString(33), rdr.GetString(34), rdr.GetString(35), rdr.GetString(36), rdr.GetString(37),
                        rdr.GetString(38), rdr.GetString(39), rdr.GetString(40), rdr.GetString(41), rdr.GetString(42),
                        rdr.GetString(43), rdr.GetString(44), rdr.GetString(45), rdr.GetInt32(46),rdr.GetString(47)
                        );
                    Certifications.Add(Certification);
                }
                return Certifications;
            }
        }
    }
}
