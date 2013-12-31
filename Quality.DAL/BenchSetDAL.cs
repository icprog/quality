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
    public class BenchSetDAL:IBenchSet
    {
        private string _connectString;
        private readonly string SQL_SELECT_ALLBENCHSET = "SP_GetAllBenchSet";
        private readonly string SQL_SELECT_BENCHSETBYID = "SP_GetBenchSetById";
        private readonly string SQL_SELECT_BENCHSETBYNAME = "SP_GetBenchSetByName";
        
        public BenchSetDAL(string con)
        {
            _connectString=con;
        }
        public IList<BenchSet> GetAllBenchSet(int creator)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_ALLBENCHSET,new SqlParameter("CREATOR",creator)))
            {
                IList<BenchSet> BenchSets = new List<BenchSet>();
                while (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    BenchSet bSet = new BenchSet(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetDateTime(7),rdr.GetInt32(8));
                    BenchSets.Add(bSet);
                }

                return BenchSets;
            }
        }

        public BenchSet GetBenchSetByName(string name,int creator)
        {
            SqlParameter[] parms =
            {
                new SqlParameter("CREATOR",creator),
                new SqlParameter("BENCHSET_NAME",name)};
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_BENCHSETBYNAME, parms))
            {

                BenchSet bSet = new BenchSet();
                if (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    bSet = new BenchSet(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetDateTime(7), rdr.GetInt32(8));

                }

                return bSet;
            }
        }


        public BenchSet GetBenchSetById(int id,int creator)
        {
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(_connectString, CommandType.StoredProcedure, SQL_SELECT_BENCHSETBYID,new SqlParameter("BENCHID",id)))
            {
               
                BenchSet bSet=new BenchSet();
                if (rdr.Read())
                {
                    //u.id,u.username,u.roleId,r.rolename,r.roleValue,u.realname
                    bSet = new BenchSet(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetDateTime(7),rdr.GetInt32(8));
                   
                }

                return bSet;
            }
        }
    }
}
