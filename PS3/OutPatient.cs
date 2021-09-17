using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3
{
    class OutPatient : Patient
    {
        DateTime dateofadmission;
        string HealthProblem;
        Address ad = new Address();

        public OutPatient(int pid, string pname)
        {
            Patientid = pid;
            Patientname = pname;

        }

        public override void getDetails()
        {
            Console.WriteLine("Enter Doorno:");
            ad.doorno = Console.ReadLine();
            Console.WriteLine("Enter Street:");
            ad.street = Console.ReadLine();
            Console.WriteLine("Enter City:");
            ad.city = Console.ReadLine();
            Console.WriteLine("Enter State:");
            ad.state = Console.ReadLine();
            int a = 0, b = 0;
            do
            {
                a = 0;
                Console.WriteLine("enter the date of admission : ");
                try
                {
                    string dt = Console.ReadLine();
                    if (DateTime.TryParse(dt, out dateofadmission))
                    {
                        string.Format("{0:dd/mm/yyyy}", dateofadmission);

                    }
                    else
                        throw new Exception();

                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid date time" + e);
                    a = 1;
                }
            } while (a == 1);
            do
            {
                b = 0;
                Console.WriteLine("enter the health problem : ");
                HealthProblem = Console.ReadLine();
                try
                {

                    if (HealthProblem.Length == 0)
                    {
                        Console.WriteLine("this field cannot be empty");

                        throw new Exception();

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid details" + e);
                    b = 1;
                }
            } while (b == 1);

        }
        public override void printDetails()
        {
            Console.WriteLine("Patients name is : " + Patientname);
            Console.WriteLine("Patients address " + ad.doorno + " " + ad.street + " " + ad.city + " " + ad.state);

            Console.WriteLine("date of admission is :" + dateofadmission.ToLongDateString());
            Console.WriteLine("health problem is : " + HealthProblem);

        }

    }
}
 