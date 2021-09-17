using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3
{
    abstract class Patient : IPatient
    {
        int patientid;
        string patientname;
        Address PatientAddress;

        public int Patientid
        {
            get
            {
                return patientid;
            }
            set
            {
                patientid = value;
            }
        }
        public string Patientname
        {
            set
            {
                patientname = value;
            }
            get
            {
                return patientname;
            }
        }
        

        public abstract void getDetails();
        public abstract void printDetails();

    }
}
