﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    public class Certification
    {
        #region 成员变量
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _serial;

        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }
        private string _certType;

        public string CertType
        {
            get { return _certType; }
            set { _certType = value; }
        }
        private string _unitName;


        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        private string _instructionName;


        public string InstructionName
        {
            get { return _instructionName; }
            set { _instructionName = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _module;

        public string Module
        {
            get { return _module; }
            set { _module = value; }
        }
        private string _manufact_no;

        public string Manufact_no
        {
            get { return _manufact_no; }
            set { _manufact_no = value; }
        }
        private string _madeby;

        public string Madeby
        {
            get { return _madeby; }
            set { _madeby = value; }
        }
        private string _according;

        public string According
        {
            get { return _according; }
            set { _according = value; }
        }
        private string _result;

        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private DateTime _expire;

        public DateTime Expire
        {
            get { return _expire; }
            set { _expire = value; }
        }
        private string _approvedBy;

        public string ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }
        private string _checkedBy;

        public string CheckedBy
        {
            get { return _checkedBy; }
            set { _checkedBy = value; }
        }
        private string _verifiedBy;

        public string VerifiedBy
        {
            get { return _verifiedBy; }
            set { _verifiedBy = value; }
        }
        private string _benchName1;

        public string BenchName1
        {
            get { return _benchName1; }
            set { _benchName1 = value; }
        }
        private string _benchName2;

        public string BenchName2
        {
            get { return _benchName2; }
            set { _benchName2 = value; }
        }
        private string _benchName3;

        public string BenchName3
        {
            get { return _benchName3; }
            set { _benchName3 = value; }
        }
        private string _benchRange1;

        public string BenchRange1
        {
            get { return _benchRange1; }
            set { _benchRange1 = value; }
        }
        private string _benchRange2;

        public string BenchRange2
        {
            get { return _benchRange2; }
            set { _benchRange2 = value; }
        }
        private string _benchRange3;

        public string BenchRange3
        {
            get { return _benchRange3; }
            set { _benchRange3 = value; }
        }
        private string _notsure1;

        public string Notsure1
        {
            get { return _notsure1; }
            set { _notsure1 = value; }
        }
        private string _notsure2;

        public string Notsure2
        {
            get { return _notsure2; }
            set { _notsure2 = value; }
        }
        private string _notsure3;

        public string Notsure3
        {
            get { return _notsure3; }
            set { _notsure3 = value; }
        }
        private string _benchSn1;

        public string BenchSn1
        {
            get { return _benchSn1; }
            set { _benchSn1 = value; }
        }
        private string _benchSn2;

        public string BenchSn2
        {
            get { return _benchSn2; }
            set { _benchSn2 = value; }
        }
        private string _benchSn3;

        public string BenchSn3
        {
            get { return _benchSn3; }
            set { _benchSn3 = value; }
        }
        private DateTime _benchexpire1;

        public DateTime Benchexpire1
        {
            get { return _benchexpire1; }
            set { _benchexpire1 = value; }
        }
        private DateTime _benchexpire2;

        public DateTime Benchexpire2
        {
            get { return _benchexpire2; }
            set { _benchexpire2 = value; }
        }
        private DateTime _benchexpire3;

        public DateTime Benchexpire3
        {
            get { return _benchexpire3; }
            set { _benchexpire3 = value; }
        }
        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _temperature;

        public string Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        private string _humidity;

        public string Humidity
        {
            get { return _humidity; }
            set { _humidity = value; }
        }
        private string _resultHTML;

        public string ResultHTML
        {
            get { return _resultHTML; }
            set { _resultHTML = value; }
        }
        private string _resultHTML2;

        public string ResultHTML2
        {
            get { return _resultHTML2; }
            set { _resultHTML2 = value; }
        }

        private string _resultHTML3;

        public string ResultHTML3
        {
            get { return _resultHTML3; }
            set { _resultHTML3 = value; }
        }
        private string _resultHTML4;

        public string ResultHTML4
        {
            get { return _resultHTML4; }
            set { _resultHTML4 = value; }
        }

        private string _licenseNotsure;

        public string LicenseNotsure
        {
            get { return _licenseNotsure; }
            set { _licenseNotsure = value; }
        }
        private string _useLimit;

        public string UseLimit
        {
            get { return _useLimit; }
            set { _useLimit = value; }
        }
        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _presure;

        public string Presure
        {
            get { return _presure; }
            set { _presure = value; }
        }
        private string _telephone;

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _benchSerial1;

        public string BenchSerial1
        {
            get { return _benchSerial1; }
            set { _benchSerial1 = value; }
        }
        private string _benchSerial2;

        public string BenchSerial2
        {
            get { return _benchSerial2; }
            set { _benchSerial2 = value; }
        }
        private string _benchSerial3;

        public string BenchSerial3
        {
            get { return _benchSerial3; }
            set { _benchSerial3 = value; }
        }
        private string _useLicense;

        public string UseLicense
        {
            get { return _useLicense; }
            set { _useLicense = value; }
        }
        private int _printCount;

        public int PrintCount
        {
            get { return _printCount; }
            set { _printCount = value; }
        }
        #endregion

        public Certification()
        {
        }
        public Certification(int id, string serial,string certType, string unitName, DateTime date, string instName,
            string module, string manufact_no, string madeby, string according, string result,
            string approvedby, string checkedBy, string verifiedby, DateTime expire,
            string benchname1, string benchId1, string benchRange1, string notsure1, string benchSn1, DateTime benchExpire1,
            string benchname2, string benchId2, string benchRange2, string notsure2, string benchSn2, DateTime benchExpire2,
            string benchname3, string benchId3, string benchRange3, string notsure3, string benchSn3, DateTime benchExpire3, 
           string location, string temperature, string presure, string humidity, string html1, string html2, string html3, string html4,
            string licenseNotsure, string useLimit, string comment, string telephone, string useLicense, int printCount, string type
            )
        {



            _certType = certType;
            _id = id;
            _serial = serial;
            _unitName = unitName;
            _date = date;
            _instructionName = instName;
            _module = module;
            _manufact_no = manufact_no;
            _madeby = madeby;
            _according = according;
            _result = result;
            _approvedBy = approvedby;
            _checkedBy = checkedBy;
            _verifiedBy = verifiedby;
            _expire = expire;
            _benchName1 = benchname1;
            _benchRange1 = benchRange1;
            _notsure1 = notsure1;
            _benchSn1 = benchSn1;
            _benchexpire1 = benchExpire1;
            _benchSerial1 = benchId1;
            if (!string.IsNullOrEmpty(benchname2))
            {
                _benchName2 = benchname2;
                _benchRange2 = benchRange2;
                _notsure2 = notsure2;
                _benchSn2 = benchSn2;
                _benchexpire2 = benchExpire2;
                _benchSerial2 = benchId2;
            }
            else
            {
                _benchName2 = "";
                _benchRange2 = "";
                _notsure2 = "";
                _benchSn2 = "";
                _benchSerial2 = "";

            }
            if (!string.IsNullOrEmpty(benchname3))
            {
                _benchName3 = benchname3;
                _benchRange3 = benchRange3;
                _notsure3 = notsure3;
                _benchSn3 = benchSn3;
                _benchexpire3 = benchExpire3;
                _benchSerial3 = benchId3;
            }
            else
            {
                _benchName3 = "";
                _benchRange3 = "";
                _notsure3 = "";
                _benchSn3 = "";
                _benchSerial3 = "";

            }
            _location = location;
            _temperature = temperature;
            _humidity = humidity;
            _resultHTML = html1;
            _resultHTML2 = html2;
            _resultHTML3 = html3;
            _resultHTML4 = html4;
            _licenseNotsure = licenseNotsure;
            _useLimit = useLimit;
            _comment = comment;
            _presure = presure;
            _telephone = telephone;
            _useLicense = useLicense;
            _printCount = printCount;
            _type = type;
        }
        public Certification(string serial, string certType, string unitName, DateTime date, string instName,
            string module, string manufact_no, string madeby, string according, string result,
            string approvedby, string checkedBy, string verifiedby, DateTime expire,
            string benchname1, string benchId1, string benchRange1, string notsure1, string benchSn1, DateTime benchExpire1,
            string benchname2, string benchId2, string benchRange2, string notsure2, string benchSn2, DateTime benchExpire2,
            string benchname3, string benchId3, string benchRange3, string notsure3, string benchSn3, DateTime benchExpire3, 
           string location, string temperature, string presure, string humidity, string html1, string html2, string html3, string html4,
            string licenseNotsure, string useLimit, string comment, string telephone, string useLicense, int printCount,string type
    )
        {



            _certType = certType;
            _serial = serial;
            _unitName = unitName;
            _date = date;
            _instructionName = instName;
            _module = module;
            _manufact_no = manufact_no;
            _madeby = madeby;
            _according = according;
            _result = result;
            _approvedBy = approvedby;
            _checkedBy = checkedBy;
            _verifiedBy = verifiedby;
            _expire = expire;
            _benchName1 = benchname1;
            _benchRange1 = benchRange1;
            _notsure1 = notsure1;
            _benchSn1 = benchSn1;
            _benchexpire1 = benchExpire1;
            _benchSerial1 = benchId1;
            if (!string.IsNullOrEmpty(benchname2))
            {
                _benchName2 = benchname2;
                _benchRange2 = benchRange2;
                _notsure2 = notsure2;
                _benchSn2 = benchSn2;
                _benchexpire2 = benchExpire2;
                _benchSerial2 = benchId2;
            }
            else
            {
                _benchName2 = "";
                _benchRange2 = "";
                _notsure2 = "";
                _benchSn2 = "";
                _benchSerial2 = "";

            }
            if (!string.IsNullOrEmpty(benchname3))
            {
                _benchName3 = benchname3;
                _benchRange3 = benchRange3;
                _notsure3 = notsure3;
                _benchSn3 = benchSn3;
                _benchexpire3 = benchExpire3;
                _benchSerial3 = benchId3;
            }
            else
            {
                _benchName3 = "";
                _benchRange3 = "";
                _notsure3 = "";
                _benchSn3 = "";
                _benchSerial3 = "";

            }
            _location = location;
            _temperature = temperature;
            _humidity = humidity;
            _resultHTML = html1;
            _resultHTML2 = html2;
            _resultHTML3 = html3;
            _resultHTML4 = html4;
            _licenseNotsure = licenseNotsure;
            _useLimit = useLimit;
            _comment = comment;
            _presure = presure;
            _telephone = telephone;
            _useLicense = useLicense;
            _printCount = printCount;
            _type = type;
        }
        public string getHtml()
        {
            string html = "<head><title></title><style type='text/css'>.tb_front td{ width: 200px;}</style></head>";

            html += "<body ><div style='height:36px;padding:0 10px 0 10px;' >";
            html += "<h2 style='position:absolute;right:5px;'>检定证书</h2>";
            html += "<h3 style='font-size:12px;position:absolute;top:36px;right:5px;margin-top:8px;'>证书编号 #<b>" + _serial + "</b></h3>";
            html += "</div>";
            html += "<div>";
            html += " <p style='font-size:12px;'>日期:" + _date.ToShortDateString() + "</p>";
            html += "<b style='font-size:22px'>" + _unitName + "</b>";
            html += " <table class='tb_front' style='margin-top:5px;font-size:12px;'>";
            html += "<tr><td>计量器具名称:" + _instructionName + "</td><td>批准人:" + _approvedBy + "</td></tr>";
            html += " <tr><td>型号/规格:" + _module + "</td><td>核验员:" + _checkedBy + "</td></tr>";
            html += " <tr><td >出厂编号:" + _manufact_no + "</td><td>鉴定员:" + _verifiedBy + "</td></tr>";
            html += "<tr><td >制造单位:" + _madeby + " </td><td>有效期至:" + _expire.ToShortDateString() + "</td></tr>";
            html += " <tr><td >检定依据:" + _according + "</td><td></td></tr>";
            html += " <tr><td >检定结论:" + _result + "</td><td></td></tr>";
            html += " <tr><td >备注:" + _comment + "</td><td></td></tr>";
            html += " <tr><td >联系方式:" + _telephone + "</td><td></td></tr>";
            html += " </table>";
            html += " <br />";
            html += " <table style='text-align:left;font-size:13px;' width=600px border=1>";
            html += "<tr><th colspan='6'>主要计量标准器具：</th></tr>";
            html += " <tr><th>名称</th><th>编号</th><th>测量范围</th><th>不确定度/准确度等级/最大允许误差</th><th>	证书编号</th><th>有效期至</th></tr>";
            html += "<tr><td>" + _benchName1 + "</td><td>" + _benchSerial1 + "</td><td>" + _benchRange1 + "</td><td>" + _notsure1 + "</td><td>" + _benchSn1 + "</td>	<td>" + _benchexpire1 + "</td></tr>";
            if (!string.IsNullOrEmpty(_benchName2))
            {
                html += "<tr><td>" + _benchName2 + "</td><td>" + _benchSerial2 + "</td><td>" + _benchRange2 + "</td><td>" + _notsure2 + "</td><td>" + _benchSn2 + "</td>	<td>" + _benchexpire2 + "</td></tr>";
            }
            if (!string.IsNullOrEmpty(_benchName3))
            {
                html += "<tr><td>" + _benchName3 + "</td><td>" + _benchSerial3 + "</td><td>" + _benchRange3 + "</td><td>" + _notsure3 + "</td><td>" + _benchSn3 + "</td>	<td>" + _benchexpire3 + "</td></tr>";
            }
            html += "<tr><th>鉴定地点：</th><td colspan='5'>" + _location + "</td></tr>";
            html += "<tr><th>检定的环境条件:</th><td colspan='5'>温度：" + _temperature + " 湿度:" + _humidity + "气压:" + _presure + "</td></tr>";
            html += "</table><table width=600px  style='text-align:left;font-size:13px;' border=1>";
            html += " <tr><th colspan=4>检定结果</th></tr><tr ><td colspan=5>" + _resultHTML + "</td></tr>";
            if (!string.IsNullOrEmpty(_licenseNotsure))
            {
                html += " <tr><th >鉴定结果的不确定度:</th><td>" + _licenseNotsure + "</td><th>限制使用条件:</th><td>" + _useLimit + "</td></tr>";
            }
            if (!string.IsNullOrEmpty(_resultHTML2))
            {
                html += " <tr><th colspan=4>检定结果(续1)</th></tr><tr><td colspan=4>" + _resultHTML2 + "</td></tr>";
            }
            if (!string.IsNullOrEmpty(_resultHTML3))
            {
                html += " <tr><th colspan=4>检定结果(续2)</th></tr><tr><td colspan=4>" + _resultHTML3 + "</td></tr>";
            }
            if (!string.IsNullOrEmpty(_resultHTML4))
            {
                html += " <tr><th colspan=4>检定结果(续3)</th></tr><tr><td colspan=4>" + _resultHTML4 + "</td></tr>";
            }
            html += "</table></div></body></html>";
            return html;

        }
        //public bool AddLicense()
        //{
        //    AccessDbClass accClass = new AccessDbClass(Application.StartupPath + "/DATA/license.mdb");
        //    string sql = "insert into license( ";
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}],[{5}],", "证书编号", "受检单位", "受检日期", "计量器具名称", "型号", "出厂编号");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}],[{5}],", "制造单位", "检定依据", "检定结论", "批准人", "核验员", "检定员");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}],[{5}],[{6}],", "有效期至", "标准器具名称1", "器具编号1", "测量范围1", "不确定度1", "标准证书编号1", "标准证书有效期1");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}],[{5}],", "标准器具名称2", "器具编号2", "测量范围2", "不确定度2", "标准证书编号2", "标准证书有效期2");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}],[{5}],", "标准器具名称3", "器具编号3", "测量范围3", "不确定度3", "标准证书编号3", "标准证书有效期3");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],", "检定地点", "温度", "气压", "湿度");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],", "检定结果1", "检定结果2", "检定结果3", "检定结果4");
        //    sql += string.Format("[{0}],[{1}],[{2}],[{3}],[{4}]", "检定结果不确定度", "限制使用条件", "备注", "联系方式", "专用证书");
        //    sql += ") values(";
        //    sql += string.Format("'{0}','{1}',#{2}#,'{3}','{4}','{5}',", _serial, _unitName, _date, _instructionName, _module, _manufact_no);
        //    sql += string.Format("'{0}','{1}','{2}','{3}','{4}','{5}',", _madeby, _according, _result, _approvedBy, _checkedBy, _verifiedBy);
        //    sql += string.Format("#{0}#,'{1}','{2}','{3}','{4}','{5}',#{6}#,", _expire, _benchName1, _benchSerial1, _benchRange1, _notsure1, _benchSn1, _benchexpire1);
        //    sql += string.Format("'{0}','{1}','{2}','{3}','{4}',#{5}#,", _benchName2, _benchSerial2, _benchRange2, _notsure2, _benchSn2, _benchexpire2);
        //    sql += string.Format("'{0}','{1}','{2}','{3}','{4}',#{5}#,", _benchName3, _benchSerial3, _benchRange3, _notsure3, _benchSn3, _benchexpire3);
        //    sql += string.Format("'{0}','{1}','{2}','{3}',", _location, _temperature, _presure, _humidity);
        //    sql += string.Format("'{0}','{1}','{2}','{3}',", _resultHTML, _resultHTML2, _resultHTML3, _resultHTML4);
        //    sql += string.Format("'{0}','{1}','{2}','{3}','{4}'", _licenseNotsure, _useLimit, _comment, _telephone, _useLicense);
        //    sql += ");";
        //    return accClass.ExecuteSQLNonquery(sql);

        //}

    }
}
