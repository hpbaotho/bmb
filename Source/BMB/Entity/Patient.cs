using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Patient
    {
        private int PatientID;

        public int PatientID_Pro
        {
            get { return PatientID; }
            set { PatientID = value; }
        }
        private String PatientName;

        public String PatientName_Pro
        {
            get { return PatientName; }
            set { PatientName = value; }
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
    }
}
