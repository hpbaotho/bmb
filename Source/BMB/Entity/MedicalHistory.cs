using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace BMB
{
    public class MedicalHistory
    {
        private int MedicalHistoryID;

        public int MedicalHistoryID_Pro
        {
            get { return MedicalHistoryID; }
            set { MedicalHistoryID = value; }
        }
        private DateTime ExamDate;

        public DateTime ExamDate_Pro
        {
            get { return ExamDate; }
            set { ExamDate = value; }
        }
        private String DiseaseStatus;

        public String DiseaseStatus_Pro
        {
            get { return DiseaseStatus; }
            set { DiseaseStatus = value; }
        }
        private String Diagnosis;

        public String Diagnosis_Pro
        {
            get { return Diagnosis; }
            set { Diagnosis = value; }
        }
        private int MedicalBookID;

        public int MedicalBookID_Pro
        {
            get { return MedicalBookID; }
            set { MedicalBookID = value; }
        }
    }
}
