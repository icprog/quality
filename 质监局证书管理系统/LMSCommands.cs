using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;

namespace 质监局证书管理系统
{
    public class LMSCommands
    {
        private DocumentCommands _LicenseCommands = new DocumentCommands();
        /// <summary>
        /// Gets the client related commands.
        /// </summary>
        public DocumentCommands LicenseCommands
        {
            get { return _LicenseCommands; }
            set { _LicenseCommands = value; }
        }
        private DialogCommands _SearchDialogCommands = new DialogCommands();

        public DialogCommands SearchDialogCommands
        {
            get { return _SearchDialogCommands; }
            set { _SearchDialogCommands = value; }
        }
       
    }

    public class DocumentCommands
    {
        private Command _New;
        public Command New
        {
            get { return _New; }
            set { _New = value; }
        }

        private Command _Save;
        public Command Save
        {
            get { return _Save; }
            set { _Save = value; }
        }

        private Command _Cancel;
        public Command Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value; }
        }
        private Command _Print;

        public Command Print
        {
            get { return _Print; }
            set { _Print = value; }
        }
        private Command _Reset;

        public Command Reset
        {
            get { return _Reset; }
            set { _Reset = value; }
        }
        private Command _Preview;

        public Command Preview
        {
            get { return _Preview; }
            set { _Preview = value; }
        }
    }
    public class DialogCommands
    {
        private Command _Open;

        public Command Open
        {
            get { return _Open; }
            set { _Open = value; }
        }


        private Command _Cancel;

        public Command Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value; }
        }
      
        
    }
}
