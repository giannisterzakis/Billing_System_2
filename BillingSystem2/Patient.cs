using System;
using System.Collections.Generic;
using System.Text;

namespace BillingSystem2
{
    class Patient
    {
        private String name;
        private int age;
        private double amount;
        private int treatmentsNum;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Amount
        {
            get { return amount; }
            set
            {
                if (age <= 5)
                {
                    amount = 0;
                }
                else if (age <= 18 && value > 50)
                {
                    amount = 50;
                }
                else
                {
                    amount = value;
                }
            }
        }

        public int Treatments
        {
            get { return treatmentsNum; }
            set { treatmentsNum = value; }
        }

        public void AddTreatment(double price)
        {
            Treatments++;
            Amount = Amount + price;
        }

        public void PayBill()
        {
            Console.Write("- Bill payed for: £" + Amount);
            Amount = 0;
        }
    }

    class InsuredPatient : Patient
    {
        private String insuranceComp;
        private int billCovered;

        public String InsuranceComp
        {
            get { return insuranceComp; }
            set { insuranceComp = value; }
        }

        public int BillCovered
        {
            get { return billCovered; }
            set { billCovered = value; }
        }

        public void ChargeInsurance()
        {
            double amount = Amount * billCovered / 100;

            Console.Write("- Charge insurance: £" + amount);
            Amount = Amount - amount;
        }
    }
}
