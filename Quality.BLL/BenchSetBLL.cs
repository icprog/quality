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
    public class BenchSetBLL
    {
        private IBenchSet dal = new Quality.DAL.BenchSetDAL(new DBManager().ConnectString);
        public IList<BenchSet> GetAllBenchSet(int creator)
        {
            return dal.GetAllBenchSet(creator);
        }
        public BenchSet GetBenchSetById(int id,int creator)
        {
            return dal.GetBenchSetById(id, creator);
        }
        public BenchSet GetBenchSetByName(string name, int cid)
        {
            return dal.GetBenchSetByName(name, cid);
        }
    }
}
