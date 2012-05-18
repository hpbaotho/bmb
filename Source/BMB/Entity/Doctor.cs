using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Doctor
    {
        private int MemberID;

        public int MemberID_Pro
        {
            get { return MemberID; }
            set { MemberID = value; }
        }
        private int FacID;

        public int FacID_Pro
        {
            get { return FacID; }
            set { FacID = value; }
        }
    }
}
