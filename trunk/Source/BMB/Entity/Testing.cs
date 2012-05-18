using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Testing
    {
        private int TestingID;

        public int TestingID_Pro
        {
            get { return TestingID; }
            set { TestingID = value; }
        }
        private int MemberID;

        public int MemberID_Pro
        {
            get { return MemberID; }
            set { MemberID = value; }
        }
        private int PatientID;

        public int PatientID_Pro
        {
            get { return PatientID; }
            set { PatientID = value; }
        }
        private String TestingType;

        public String TestingType_Pro
        {
            get { return TestingType; }
            set { TestingType = value; }
        }
        private DateTime Date;

        public DateTime Date_Pro
        {
            get { return Date; }
            set { Date = value; }
        }
        private String Description;

        public String Description_Pro
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
