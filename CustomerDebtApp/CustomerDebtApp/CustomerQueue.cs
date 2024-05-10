using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDebtApp
{
    class CustomerQueue
    {

        private int maxsize = 10;
        private Customer[] customers;
        private int tail = 0;
        private int head = 0;
        private int countCustomer = 0;
        


        public CustomerQueue()
        {
            customers = new Customer[maxsize];
        }
        public CustomerQueue(int size)
        {
            maxsize = size;
            customers = new Customer[maxsize];
        }
        public void Enqueue(string name,  int age, string address, float amtowed)
        {
            Customer create_customer = new Customer(name, age, address, amtowed);
            customers[tail] = create_customer;
            tail++;
            //tail = tail + 1;
            countCustomer++;

            if (tail == maxsize)
            {
                tail = 0;

            }



        }
        public Customer Dequeue()
        {
            Customer remove_customer = customers[head];
            customers[head] = null;
            head++;
            countCustomer--;
            //head = head + 1;
            if (tail == maxsize)//check wrap around
            {
                head = 0;
            }
           
            return remove_customer;
        }
        public int Count()
        {
            return countCustomer;
        }

        public Customer Peek()
        {
            return customers[head];
            
            
        }

        public bool IsEmpty()
        {
            return countCustomer == 0;
        }

        public bool IsFull()
        {
            return countCustomer == maxsize;
        }

      

        public float TotalAmountOwed()
        {
            float total = 0;
           
           foreach(var customer  in customers)
            {
               
                if (customer != null)
                {
                    total += customer.AmountOwed;
                }
            }
            return total;
            

        }

        public string MaximumAmountOwed()
        {
            Customer maxCustomer = null;
            for (int i = 0; i < customers.Length; i++)
            {
                Customer customer = customers[i];
                if (customer != null)
                {
                    if (maxCustomer == null || customer.AmountOwed > maxCustomer.AmountOwed)
                    {
                        maxCustomer = customer;
                    }
                }
            }

            if (maxCustomer != null)
            {
                return maxCustomer.GetInformation();
            }
            else
            {
                return "No customers found";
            }
        }

        public string display()
        {
            StringBuilder disp = new StringBuilder();
            for (int i = head; i <= tail - 1; i++)
            {
                disp.Append(customers[i].GetInformation());
            }
            return disp.ToString();
        }







    }

}
