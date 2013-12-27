using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    public class BenchSet
    {
        #region 成员变量
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _setName;

        public string SetName
        {
            get { return _setName; }
            set { _setName = value; }
        }
        private string _notsure;

        public string Notsure
        {
            get { return _notsure; }
            set { _notsure = value; }
        }
        private string _benchName;

        public string BenchName
        {
            get { return _benchName; }
            set { _benchName = value; }
        }
        private DateTime _expire;

        public DateTime Expire
        {
            get { return _expire; }
            set { _expire = value; }
        }
        private string _benchSerial;

        public string BenchSerial
        {
            get { return _benchSerial; }
            set { _benchSerial = value; }
        }
        private string _benchSn;

        public string BenchSn
        {
            get { return _benchSn; }
            set { _benchSn = value; }
        }
        private string _benchRange;

        public string BenchRange
        {
            get { return _benchRange; }
            set { _benchRange = value; }
        }
        #endregion
        #region //构造函数
        public BenchSet(string id, string name, string bench_sn, string benchName, string notsure, string serial, string range, DateTime expire)
        {
            _id = id;
            _setName = name;
            _benchRange = range;
            _benchSerial = serial;
            _benchSn = bench_sn;
            _notsure = notsure;
            _benchName = benchName;
            _expire = expire;
        }
        public BenchSet(string name, string range, string serial, string bench_sn, string notsure, string benchName, DateTime expire)
        {
            _setName = name;
            _benchRange = range;
            _benchSerial = serial;
            _benchSn = bench_sn;
            _notsure = notsure;
            _benchName = benchName;
            _expire = expire;
        }
        #endregion

    }
}
