using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDebtApp
{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
    class Customer
    {

        private string name;
        private int age;
        private string address;
        private float amountOwed;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float AmountOwed
        {
            get { return amountOwed; }
            set { amountOwed = value; }
        }

        // Constructor
        public Customer()
        {
            this.name = " ";
            this.age = 0;
            this.address = " ";
            this.amountOwed = 0;
        }


        public Customer(string name, int age, string address, float amountOwed)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.amountOwed = amountOwed;

        }

        //concatenation of customer informationm 
        public string GetInformation()
        {
            return (Name + " ," + age + " ," + Address + " ," + amountOwed + '\n');
        }


    }
}
