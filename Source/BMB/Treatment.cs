using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class Treatment
    {
        private int TreatmentID;

        public int TreatmentID_Pro
        {
            get { return TreatmentID; }
            set { TreatmentID = value; }
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
        private DateTime Date;

        public DateTime Date_Pro
        {
            get { return Date; }
            set { Date = value; }
        }
        private String ExamDetails;

        public String ExamDetails_Pro
        {
            get { return ExamDetails; }
            set { ExamDetails = value; }
        }
        private String Diagnosis;

        public String Diagnosis_Pro
        {
            get { return Diagnosis; }
            set { Diagnosis = value; }
        }
        private String Description;

        public String Description_Pro
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
