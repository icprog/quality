using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.AdvTree;
using Quality.Model;
using Quality.BLL;
namespace 质监局证书管理系统
{
    public partial class CertificateSearch : UserControl
    {
        private LMSCommands _Commands;
        CertificationBLL bll;
        public LMSCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    LMSCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        private void InitCertificationList()
        {
             bll= new CertificationBLL();
            IList<Certification> _certifications = bll.GetAllCertifications();
            for (int i = 0; i < _certifications.Count; i++)
            {
                advTree1.Nodes.Add(CreateLicenseNode(_certifications[i].Id, _certifications[i].Serial, _certifications[i].CertType, _certifications[i].UnitName, _certifications[i].Type, _certifications[i].Madeby, _certifications[i].Date, _certifications[i].Expire, _certifications[i].VerifiedBy));
                //advTree_licenseList.Nodes.Add(CreateLicenseNode(dt.Rows[i]["证书编号"].ToString(), dt.Rows[i]["受检单位"].ToString(), Convert.ToDateTime(dt.Rows[i]["受检日期"].ToString()), int.Parse(dt.Rows[i]["ID"].ToString()), dt.Rows[i]["计量器具名称"].ToString(), dt.Rows[i]["检定员"].ToString(), dt.Rows[i]["型号"].ToString(), dt.Rows[i]["出厂编号"].ToString()));
            }
        }
        private void BindData()
        {
            advTree1.Nodes.Clear();
            bll = new CertificationBLL();
            IList<Certification> _certifications = bll.GetCertificationsBySearch(tb_keyword.Text, comb_range.Text, comb_type.Text, dt_start.Value, dt_end.Value, dt_expire1.Value, dt_expire2.Value);
            for (int i = 0; i < _certifications.Count; i++)
            {
                advTree1.Nodes.Add(CreateLicenseNode(_certifications[i].Id, _certifications[i].Serial, _certifications[i].CertType, _certifications[i].UnitName, _certifications[i].Type, _certifications[i].Madeby, _certifications[i].Date, _certifications[i].Expire, _certifications[i].VerifiedBy));
                //advTree_licenseList.Nodes.Add(CreateLicenseNode(dt.Rows[i]["证书编号"].ToString(), dt.Rows[i]["受检单位"].ToString(), Convert.ToDateTime(dt.Rows[i]["受检日期"].ToString()), int.Parse(dt.Rows[i]["ID"].ToString()), dt.Rows[i]["计量器具名称"].ToString(), dt.Rows[i]["检定员"].ToString(), dt.Rows[i]["型号"].ToString(), dt.Rows[i]["出厂编号"].ToString()));
            }

        }
        protected virtual void OnCommandsChanged(LMSCommands oldValue, LMSCommands newValue)
        {
            if (newValue != null)
            {
                btn_exit.Command = newValue.SearchDialogCommands.Cancel;
            }
            else
            {
                btn_exit.Command = null;
            //    btn_cancel.Command = null;
            //    btn_preview.Command = null;
            //    btn_print.Command = null;
            //    btn_reset.Command = null;
            }
        }
        public CertificateSearch()
        {
            InitializeComponent();
            InitCertificationList();
            
            
        }
        public Node CreateLicenseNode(int id,string serialNo, string certType, string  unitName, string type, string madeby,DateTime date,DateTime expire, string recorder)
        {
            Node node = new Node(serialNo);
            node.Cells.Add(new Cell(certType));

            node.Cells.Add(new Cell(unitName));
            node.Cells.Add(new Cell(type));
            node.Cells.Add(new Cell(madeby));
          
            node.Cells.Add(new Cell(date.ToShortDateString()));
            node.Cells.Add(new Cell(expire.ToShortDateString()));
            node.Cells.Add(new Cell(recorder));
            node.Tag = id;
            return node;
        }
        private void UpdateControlsSizeAndLocation()
        {

            metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1);
           
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }


        private void CertificateSearch_Load(object sender, EventArgs e)
        {
            UpdateControlsSizeAndLocation();
        }

        private void metroToolbar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void expandablePanel1_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (!expandablePanel1.Expanded)
            {
                splitContainer1.SplitterDistance = 50;
               
            }
            else
            {
                splitContainer1.SplitterDistance = 112;
               
            }
            UpdateControlsSizeAndLocation();
        }

        private void dateTimeInput2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            comb_range.ResetText();
            comb_type.ResetText();
            dt_start.ResetText();
            dt_end.ResetText();
            dt_expire1.ResetText();
            dt_expire2.ResetText();
            tb_keyword.Text = "";
        }

      
     
    }
}
