using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quality.Model
{
    public class Settings
    {
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
    }
}
