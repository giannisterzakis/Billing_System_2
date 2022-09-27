using System;

namespace BillingSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Design
            Console.Title = "Billing System 2";
            Console.ForegroundColor = ConsoleColor.Yellow;

            // patient1
            Patient patient1 = new Patient();
            patient1.Name = "Ioannis Terzakis";
            patient1.Age = 17;
            patient1.AddTreatment(150.00);
            patient1.AddTreatment(100.00);

            Console.WriteLine("Patient " + patient1.Name + " has had " + patient1.Treatments + " treatments and current bill is: £" + patient1.Amount);
            Console.WriteLine();

            patient1.PayBill();
            Console.WriteLine();

            Console.WriteLine("- Current Bill: £" + patient1.Amount);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // patient2
            InsuredPatient patient2 = new InsuredPatient();
            patient2.Name = "Mark Zuckerberg";
            patient2.Age = 36;
            patient2.BillCovered = 100;
            patient2.AddTreatment(82.00);

            Console.WriteLine("Patient " + patient2.Name + " has had " + patient2.Treatments + " treatments and current bill is: £" + patient2.Amount);
            Console.WriteLine();

            patient2.ChargeInsurance();
            Console.WriteLine();

            patient2.PayBill();
            Console.WriteLine();

            Console.WriteLine("- Current Bill: £" + patient2.Amount);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // patient3
            Patient patient3 = new Patient();
            patient3.Name = "David Sener";
            patient3.Age = 4;
            patient3.AddTreatment(100.00);
            patient3.AddTreatment(80.00);
            patient3.AddTreatment(140.00);

            Console.WriteLine("Patient " + patient3.Name + " has had " + patient3.Treatments + " treatments and current bill is: £" + patient3.Amount);
            Console.WriteLine();

            patient3.PayBill();
            Console.WriteLine();

            Console.WriteLine("- Current Bill: £" + patient3.Amount);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Exit from application
            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
