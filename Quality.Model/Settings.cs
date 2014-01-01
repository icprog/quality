using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    public class Settings
    {
        private int _id;

        public int Id
        {
          get { return _id; }
          set { _id = value; }
        }
        private string _settingName;

            public string SettingName
            {
              get { return _settingName; }
              set { _settingName = value; }
            }
        private string _verificationNo;

        public string VerificationNo
        {
            get { return _verificationNo; }
            set { _verificationNo = value; }
        }
        private string _telephone;

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _addrChs;

        public string AddrChs
        {
            get { return _addrChs; }
            set { _addrChs = value; }
        }
        private string _addrEng;

        public string AddrEng
        {
            get { return _addrEng; }
            set { _addrEng = value; }
        }
        private string _zipcode;

        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }
        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _standard1;

        public string Standard1
        {
            get { return _standard1; }
            set { _standard1 = value; }
        }
        private string _standard2;

        public string Standard2
        {
            get { return _standard2; }
            set { _standard2 = value; }
        }
        private string _authUnitChs;

        public string AuthUnitChs
        {
            get { return _authUnitChs; }
            set { _authUnitChs = value; }
        }
        private string _authUnitEng;

        public string AuthUnitEng
        {
            get { return _authUnitEng; }
            set { _authUnitEng = value; }
        }
        private int _isUse;

        public int IsUse
        {
          get { return _isUse; }
          set { _isUse = value; }
        }
        public Settings()
        {
        }
        public Settings(int id, string set_name, string addrChs, 
                    string addrEng, string unitChs, string unitEng, 
                    string email, string fax, string standard1,
                    string standard2, string telephone, 
                    string verificationNo, string zipcode, int isUse)
        {
            _id = id;
            _settingName = set_name;
            _addrChs = addrChs;
            _addrEng = addrEng;
            _email = email;
            _authUnitChs = unitChs;
            _authUnitEng = unitEng;
            _fax = fax;
            _standard1 = standard1;
            _standard2 = standard2;
            _telephone = telephone;
            _verificationNo = verificationNo;
            _zipcode = zipcode;
            _isUse = isUse;
        }
        public Settings(string set_name, string addrChs, string addrEng, string unitChs, string unitEng, string email, string fax, string standard1, string standard2, string telephone, string verificationNo, string zipcode, int isUse)
        {
            _settingName = set_name;
            _addrChs = addrChs;
            _addrEng = addrEng;
            _email = email;
            _authUnitChs = unitChs;
            _authUnitEng = unitEng;
            _fax = fax;
            _standard1 = standard1;
            _standard2 = standard2;
            _telephone = telephone;
            _verificationNo = verificationNo;
            _zipcode = zipcode;
            _isUse = isUse;
        }
    }
}
