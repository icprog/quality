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
    public class CertificationDAL : ICertification
    {

        private readonly string SQL_SELECT_ALLCERTIFICATION = "SP_GETALLCERTIFICATION";
        private readonly string SQL_SELECT_CERTIFICATIONBYSEARCH = "SP_GetCertificationByCondition";
        private readonly string SQL_INSERT_CERTIFICATION = "SP_AddCertification";
        private readonly string SQL_UPDATE_PRINTONCE = "SP_PrintOnce";
        private string _connectString;
        public CertificationDAL(string connectionStr)
        {
            _connectString = connectionStr;
        }
        public bool AddCertification(Certification certification)
        {
            SqlParameter[] parms =
            {

                new SqlParameter("CERTID",certification.Serial),
                new SqlParameter("CERTTYPE",certification.CertType),
             new SqlParameter("UNITNAME ",certification.UnitName),
                new SqlParameter("DATE",certification.Date.ToString()),
             new SqlParameter("INSTNAME",certification.InstructionName),
                new SqlParameter("MODULE",certification.Module),
             new SqlParameter("MANUFACTNO",certification.Manufact_no),
             new SqlParameter("MADEBY ",certification.Madeby),
                new SqlParameter("ACCORDING ",certification.According),
                 new SqlParameter("RESULT ",certification.Result),
             new SqlParameter("APPROVER",certification.ApprovedBy),
                new SqlParameter("CHECKER",certification.CheckedBy),
             new SqlParameter("VERIFYER",certification.VerifiedBy),
                new SqlParameter("EXPIRE",certification.Expire.ToString()),
             new SqlParameter("BENCHNAME1",certification.BenchName1),
                new SqlParameter("BENCHID1",certification.BenchSerial1),
             new SqlParameter("NOTSURE1",certification.Notsure1),
                new SqlParameter("BENCHSN1",certification.BenchSn1),
             new SqlParameter("BENCHEXPIRE1",certification.Benchexpire1.ToString()),
                new SqlParameter("BENCHRANGE1",certification.BenchRange1),

             new SqlParameter("BENCHNAME2",certification.BenchName2),
                new SqlParameter("BENCHID2",certification.BenchSerial2),
             new SqlParameter("NOTSURE2",certification.Notsure2),
                new SqlParameter("BENCHSN2",certification.BenchSn2),
             new SqlParameter("BENCHEXPIRE2",certification.Benchexpire2.ToString()),
                new SqlParameter("BENCHRANGE2",certification.BenchRange2),

             new SqlParameter("BENCHNAME3",certification.BenchName3),
                new SqlParameter("BENCHID3",certification.BenchSerial3),
             new SqlParameter("NOTSURE3",certification.Notsure3),
                new SqlParameter("BENCHSN3",certification.BenchSn3),
             new SqlParameter("BENCHEXPIRE3",certification.Benchexpire3.ToString()),
                new SqlParameter("BENCHRANGE3",certification.BenchRange3),

             new SqlParameter("LOCATION",certification.Location),
                new SqlParameter("TEMPERATURE",certification.Temperature),
             new SqlParameter("PRESSURE",certification.Presure),
                new SqlParameter("HUMIDITY",certification.Humidity),
             new SqlParameter("HTML1",certification.ResultHTML),
                new SqlParameter("HTML2",certification.ResultHTML2),
             new SqlParameter("HTML3",certification.ResultHTML3),
                new SqlParameter("HTML4",certification.ResultHTML4),
             new SqlParameter("NOTSURE",certification.LicenseNotsure),
                new SqlParameter("USELIMIT",certification.UseLimit),
                new SqlParameter("COMMENT",certification.Comment),
                new SqlParameter("TELEPHONE",certification.Telephone),
        new SqlParameter("USELICENSE",certification.UseLicense),
            new SqlParameter("PRINTCOUNT",certification.PrintCount),
            new SqlParameter("INSTTYPE",certification.Type)
        
        };
            int result = SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_INSERT_CERTIFICATION, parms);
            if (result == 1)
            {
                return true;
            }
            else return false;
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
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_ALLCERTIFICATION))
            {
                IList<Certification> Certifications = new List<Certification>();
                while (rdr.Read())
                {
                    Certification Certification =
                        new Certification(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        Convert.ToDateTime(rdr.GetString(4)), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetString(13), Convert.ToDateTime(rdr.GetString(14)),
                        rdr.GetString(15), rdr.GetString(16), rdr.GetString(17), rdr.GetString(18), rdr.GetString(19), Convert.ToDateTime(rdr.GetString(20)),
                         rdr.GetString(21), rdr.GetString(22), rdr.GetString(23), rdr.GetString(24), rdr.GetString(25), Convert.ToDateTime(rdr.GetString(26)),
                          rdr.GetString(27), rdr.GetString(28), rdr.GetString(29), rdr.GetString(30), rdr.GetString(31), Convert.ToDateTime(rdr.GetString(32)),
                        rdr.GetString(33), rdr.GetString(34), rdr.GetString(35), rdr.GetString(36), rdr.GetString(37),
                        rdr.GetString(38), rdr.GetString(39), rdr.GetString(40), rdr.GetString(41), rdr.GetString(42),
                        rdr.GetString(43), rdr.GetString(44), rdr.GetString(45), rdr.GetInt32(46), rdr.GetString(47)
                        );
                    Certifications.Add(Certification);
                }
                return Certifications;
            }
        }

        public IList<Certification> GetCertificationsByCondition(string range, string keyword, DateTime dateRange1, DateTime dateRange2, string type, DateTime expire1, DateTime expire2)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("KEYWORD",keyword),
                new SqlParameter("STARTDATE", dateRange1.ToString()),
                new SqlParameter("ENDDATE",dateRange2.ToString()),
                new SqlParameter("CERTTYPE",type),
                new SqlParameter("RANGE",range),
                new SqlParameter("EXPIRE1",expire1.ToString()),
                new SqlParameter("EXPIRE2",expire2.ToString())
            };
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_CERTIFICATIONBYSEARCH, parms))
            {
                IList<Certification> Certifications = new List<Certification>();
                while (rdr.Read())
                {
                    Certification Certification =
                         new Certification(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        Convert.ToDateTime(rdr.GetString(4)), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9), rdr.GetString(10), rdr.GetString(11), rdr.GetString(12), rdr.GetString(13), Convert.ToDateTime(rdr.GetString(14)),
                        rdr.GetString(15), rdr.GetString(16), rdr.GetString(17), rdr.GetString(18), rdr.GetString(19), Convert.ToDateTime(rdr.GetString(20)),
                         rdr.GetString(21), rdr.GetString(22), rdr.GetString(23), rdr.GetString(24), rdr.GetString(25), Convert.ToDateTime(rdr.GetString(26)),
                          rdr.GetString(27), rdr.GetString(28), rdr.GetString(29), rdr.GetString(30), rdr.GetString(31), Convert.ToDateTime(rdr.GetString(32)),
                        rdr.GetString(33), rdr.GetString(34), rdr.GetString(35), rdr.GetString(36), rdr.GetString(37),
                        rdr.GetString(38), rdr.GetString(39), rdr.GetString(40), rdr.GetString(41), rdr.GetString(42),
                        rdr.GetString(43), rdr.GetString(44), rdr.GetString(45), rdr.GetInt32(46), rdr.GetString(47)
                        );
                    Certifications.Add(Certification);
                }
                return Certifications;
            }
        }


        public void PrintOnce(string SerialNo)
        {
            SqlHelper.ExecuteNonQuery(_connectString, CommandType.StoredProcedure, SQL_UPDATE_PRINTONCE, new SqlParameter("@SERIAL", SerialNo));
        }
    }
}
