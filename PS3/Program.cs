using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pid;
            string Pname;
            
            List<InPatient> p1 = new List<InPatient>();
            List<OutPatient> p2 = new List<OutPatient>();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Add In Patient details");
            Console.WriteLine("2.View In Patient details");
            Console.WriteLine("3.Add Out Patient details");
            Console.WriteLine("4.View Out Patient details");
            Console.WriteLine("6.Update in patient details:");
            Console.WriteLine("7.Update out patient details:");
            Console.WriteLine("5.Exit");
            int choice = int.Parse(Console.ReadLine());

            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Patient id:");
                        Pid = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Patient name:");
                        Pname = Console.ReadLine();

                       

                        InPatient objinpatient = new InPatient(Pid, Pname);
                        objinpatient.getDetails();
                        p1.Add(objinpatient);

                        break;


                    case 2:
                        Console.WriteLine("Enter Patient id:");
                        Pid = int.Parse(Console.ReadLine());
                        foreach (InPatient ent in p1)
                        {
                            if (ent.Patientid == Pid)
                            {
                                ent.printDetails();
                            }
                        }
                        break;


                    case 3:
                        Console.WriteLine("Enter Patient id:");
                        Pid = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Patient name:");
                        Pname = Console.ReadLine();

                        
                        OutPatient objoutpatient = new OutPatient(Pid, Pname);
                        objoutpatient.getDetails();
                        p2.Add(objoutpatient);
                        break;


                    case 4:
                        Console.WriteLine("Enter Patient id:");
                        Pid = int.Parse(Console.ReadLine());
                        foreach (OutPatient ont in p2)
                        {
                            if (ont.Patientid == Pid)
                            {
                                ont.printDetails();
                            }
                        }
                        break;


                    case 6:
                        Console.WriteLine("Enter Patient id:");
                        Pid = int.Parse(Console.ReadLine());
                        foreach (InPatient ent in p1)
                        {
                            if (ent.Patientid == Pid)
                            {
                                
                                ent.getDetails();
                            }
                        }

                        break;
                }
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add In Patient details");
                Console.WriteLine("2.View In Patient details");
                Console.WriteLine("3.Add Out Patient details");
                Console.WriteLine("4.View Out Patient details");
                Console.WriteLine("5.Exit");
                choice = int.Parse(Console.ReadLine());

            } while (choice != 5);
        }
    }
}
