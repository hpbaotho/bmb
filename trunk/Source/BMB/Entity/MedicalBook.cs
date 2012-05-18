using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class MedicalBook
    {
        private int MedicalBookID;

        public int MedicalBookID_Pro
        {
            get { return MedicalBookID; }
            set { MedicalBookID = value; }
        }
        private String Description;

        public String Description_Pro
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
