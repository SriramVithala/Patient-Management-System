using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3
{
    interface IPatient
    {
        int Patientid { get; set; }
        string Patientname { get; set; }
        

        void getDetails();
        void printDetails();
    }
}
