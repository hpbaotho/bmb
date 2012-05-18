using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Nurse
    {
        private int MemberID;

        public int MemberID_Pro
        {
            get { return MemberID; }
            set { MemberID = value; }
        }
    }
}
