using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Faculty
    {
        private int FacID;

        public int FacID_Pro
        {
            get { return FacID; }
            set { FacID = value; }
        }
        private String FacName;

        public String FacName_Pro
        {
            get { return FacName; }
            set { FacName = value; }
        }
    }
}
