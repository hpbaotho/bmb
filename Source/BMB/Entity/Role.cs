using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Role
    {
        private int RoleID;

        public int RoleID_Pro
        {
            get { return RoleID; }
            set { RoleID = value; }
        }
        private string RoleName;

        public string RoleName_Pro
        {
            get { return RoleName; }
            set { RoleName = value; }
        }
        private string Description;

        public string Description_Pro
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
