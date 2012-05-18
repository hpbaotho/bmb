using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace BMB.Entity
{
    public class Member
    {
        private int MemberID;

        public int MemberID_Pro
        {
            get { return MemberID; }
            set { MemberID = value; }
        }
        private String MemberName;

        public String MemberName_Pro
        {
            get { return MemberName; }
            set { MemberName = value; }
        }
        private DateTime DoB;

        public DateTime DoB_Pro
        {
            get { return DoB; }
            set { DoB = value; }
        }
        private String Address;

        public String Address_Pro
        {
            get { return Address; }
            set { Address = value; }
        }
        private int RoleID;

        public int RoleID_Pro
        {
            get { return RoleID; }
            set { RoleID = value; }
        }
    }
}
