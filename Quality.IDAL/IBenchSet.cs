using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quality.Model;
namespace Quality.IDAL
{
    public interface IBenchSet
    {
        IList<BenchSet> GetAllBenchSet(int creator);
        BenchSet GetBenchSetByName(string name,int creator);
        BenchSet GetBenchSetById(int id,int creator);

    }
}
