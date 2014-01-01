using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quality.Model;
namespace 质监局证书管理系统
{
    public partial class LicensePreview : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string _htmlFilePath;
        public LicensePreview(Certification cert)
        {
            InitializeComponent();
            
            //int total = 2;
            //web_dummy.Document.GetElementById("frontLicenseNo").InnerText = cert.Serial;
            //web_dummy.Document.GetElementById("unitName").InnerText = cert.UnitName;
            //web_dummy.Document.GetElementById("instName").InnerText = cert.InstructionName;
            //web_dummy.Document.GetElementById("model").InnerText = cert.Module;
            //web_dummy.Document.GetElementById("manufactNo").InnerText = cert.Manufact_no;
            //web_dummy.Document.GetElementById("madeBy").InnerText = cert.Madeby;
            //web_dummy.Document.GetElementById("accordingTo").InnerText = cert.According;
            //web_dummy.Document.GetElementById("result").InnerText = cert.Result;
            //web_dummy.Document.GetElementById("approver").InnerText = cert.ApprovedBy;
            //web_dummy.Document.GetElementById("checker").InnerText = cert.CheckedBy;
            //web_dummy.Document.GetElementById("recorder").InnerText = cert.VerifiedBy;
            //web_dummy.Document.GetElementById("date_y").InnerText = cert.Date.Year.ToString();
            //web_dummy.Document.GetElementById("date_m").InnerText = cert.Date.Month.ToString();
            //web_dummy.Document.GetElementById("date_d").InnerText = cert.Date.Day.ToString();
            //web_dummy.Document.GetElementById("expire_y").InnerText = cert.Expire.Year.ToString();
            //web_dummy.Document.GetElementById("expire_m").InnerText = cert.Expire.Month.ToString();
            //web_dummy.Document.GetElementById("expire_d").InnerText = cert.Expire.Day.ToString();
            //web_dummy.Document.GetElementById("verificationNo").InnerText = ConfigurationManager.AppSettings["verificationNumber"].ToString();
            //web_dummy.Document.GetElementById("tel").InnerText = ConfigurationManager.AppSettings["telephone"].ToString();
            //web_dummy.Document.GetElementById("zipcode").InnerText = ConfigurationManager.AppSettings["zipcode"].ToString();
            //web_dummy.Document.GetElementById("address").InnerText = ConfigurationManager.AppSettings["address"].ToString();
            //web_dummy.Document.GetElementById("fax").InnerText = ConfigurationManager.AppSettings["fax"].ToString();
            //web_dummy.Document.GetElementById("email").InnerText = ConfigurationManager.AppSettings["email"].ToString();
            //web_dummy.Document.GetElementById("header_license1").InnerText = "证书编号：" + cert.Serial;
            //web_dummy.Document.GetElementById("standard1").InnerText = ConfigurationManager.AppSettings["standard1"].ToString();
            //web_dummy.Document.GetElementById("standard2").InnerText = ConfigurationManager.AppSettings["standard2"].ToString();
            //if (!string.IsNullOrEmpty(cert.BenchName1))
            //{
            //    web_dummy.Document.GetElementById("bench_name").InnerHtml = "<span>" + cert.BenchName1 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchName2))
            //{
            //    web_dummy.Document.GetElementById("bench_name").InnerHtml += "<span>" + cert.BenchName2 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchName3))
            //{
            //    web_dummy.Document.GetElementById("bench_name").InnerHtml += "<span>" + cert.BenchName3 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchRange1))
            //{
            //    web_dummy.Document.GetElementById("bench_range").InnerHtml = "<span>" + cert.BenchRange1 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchRange2))
            //{
            //    web_dummy.Document.GetElementById("bench_range").InnerHtml += "<span>" + cert.BenchRange2 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchRange3))
            //{
            //    web_dummy.Document.GetElementById("bench_range").InnerHtml += "<span>" + cert.BenchRange3 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.Notsure1))
            //{
            //    web_dummy.Document.GetElementById("bench_notsure").InnerHtml = "<span>" + cert.Notsure1 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.Notsure2))
            //{
            //    web_dummy.Document.GetElementById("bench_notsure").InnerHtml += "<span>" + cert.Notsure2 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.Notsure3))
            //{
            //    web_dummy.Document.GetElementById("bench_notsure").InnerHtml += "<span>" + cert.Notsure3 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchSn1))
            //{
            //    web_dummy.Document.GetElementById("bench_sn").InnerHtml = "<span>" + cert.BenchSn1 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchSn2))
            //{
            //    web_dummy.Document.GetElementById("bench_sn").InnerHtml += "<span>" + cert.BenchSn2 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchSn3))
            //{
            //    web_dummy.Document.GetElementById("bench_sn").InnerHtml += "<span>" + cert.BenchSn3 + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchName1))
            //{
            //    web_dummy.Document.GetElementById("bench_expire").InnerHtml = "<span>" + cert.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchName2))
            //{
            //    web_dummy.Document.GetElementById("bench_expire").InnerHtml += "<span>" + cert.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            //}
            //if (!string.IsNullOrEmpty(cert.BenchName3))
            //{
            //    web_dummy.Document.GetElementById("bench_expire").InnerHtml += "<span>" + cert.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            //}
            //web_dummy.Document.GetElementById("location").InnerText = cert.Location;
            //web_dummy.Document.GetElementById("temperature").InnerText = cert.Temperature + "   ℃";
            //web_dummy.Document.GetElementById("humidity").InnerText = cert.Humidity + "   %RH";
            //web_dummy.Document.GetElementById("presure").InnerText = cert.Presure + "   kpa";
            //if (!string.IsNullOrEmpty(cert.ResultHTML))
            //{
            //    web_dummy.Document.GetElementById("htmlresultA").InnerHtml = cert.ResultHTML;
            //    web_dummy.Document.GetElementById("page1").Style = "page-break-after: always;";
            //}
            //if (!string.IsNullOrEmpty(cert.ResultHTML2))
            //{
            //    web_dummy.Document.GetElementById("htmlresultB").InnerHtml = cert.ResultHTML2;
            //    web_dummy.Document.GetElementById("page2").Style = "page-break-after: always;";
            //    total++;
            //}
            //else
            //{

            //    web_dummy.Document.GetElementById("page3").Style = "display:none";


            //}
            //if (!string.IsNullOrEmpty(cert.ResultHTML3))
            //{
            //    web_dummy.Document.GetElementById("htmlresultC").InnerHtml = cert.ResultHTML3;
            //    web_dummy.Document.GetElementById("page3").Style = "page-break-after: always;";
            //    total++;
            //}
            //else
            //{

            //    web_dummy.Document.GetElementById("page4").Style = "display:none";
            //}
            //if (!string.IsNullOrEmpty(cert.ResultHTML4))
            //{
            //    web_dummy.Document.GetElementById("htmlresultD").InnerHtml = cert.ResultHTML4;
            //    total++;
            //}
            //else
            //{
            //    web_dummy.Document.GetElementById("page5").Style = "display:none";
            //    //web_dummy.Document.GetElementById("page4").Style += "page-break-after: avoid;";
            //}
            //web_dummy.Document.GetElementById("totalPage1").InnerText = total.ToString();
            //web_dummy.Document.GetElementById("totalPage2").InnerText = total.ToString();
            //web_dummy.Document.GetElementById("totalPage3").InnerText = total.ToString();
            //web_dummy.Document.GetElementById("totalPage4").InnerText = total.ToString();
            //web_dummy.Document.GetElementById("totalPage5").InnerText = total.ToString();
            //web_dummy.Document.GetElementById("header_license1").InnerText = "证书编号:" + cert.Serial;
            //web_dummy.Document.GetElementById("header_license2").InnerText = "证书编号:" + cert.Serial;
            //web_dummy.Document.GetElementById("header_license3").InnerText = "证书编号:" + cert.Serial;
            //web_dummy.Document.GetElementById("header_license4").InnerText = "证书编号:" + cert.Serial;
            //if (isPreviewCalled)
            //{
            //    web_dummy.ShowPrintPreviewDialog();
            //    isPreviewCalled = false;
            //}
            //else if (isPrintCalled)
            //{
            //    web_dummy.ShowPrintDialog();
            //    isPrintCalled = false;
            //}
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}