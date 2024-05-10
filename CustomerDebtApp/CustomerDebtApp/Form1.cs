using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerDebtApp
{
    public partial class Form1 : Form
    {
        private CustomerQueue newcustomer;
        public Form1()
        {
            InitializeComponent();
            newcustomer = new CustomerQueue();
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            int.TryParse(Age_TextBox.Text, out int age);
            float.TryParse(AmountOwed_TextBox.Text, out float amountOwed);

            // Customer customer = new Customer(Name_TextBox.Text, age, Address_TextBox.Text, amountOwed);
            newcustomer.Enqueue(Name_TextBox.Text, age, Address_TextBox.Text, amountOwed);

            // Clear the textboxes used for entering customer information
            Name_TextBox.Clear();
            Age_TextBox.Clear();
            Address_TextBox.Clear();
            AmountOwed_TextBox.Clear();

            //Display(customer);
            //Display_Info
            CustomerCount.Text = $"Number of Customers in Queue: {newcustomer.Count()}";

            Customer_Max_Debt_Label.Text = $" Highest Customer: {newcustomer.MaximumAmountOwed()}";

            Total_Owed_Label.Text = $"Total Debt Owned: {newcustomer.TotalAmountOwed()}";

            Display_Info.Text = newcustomer.display();



        }
       /* private void Display(Customer customer)
        { 
            if (customer != null)
            {
                Display_Info.Text = customer.GetInformation();
            }
            // Decrease the total amount owed by the dequeued customer's amount owed
            CustomerCount.Text = $"Number of Customers in Queue: {newcustomer.Count()}";

            Customer_Max_Debt_Label.Text = $" Highest Customer: {newcustomer.MaximumAmountOwed()}";

            Total_Owed_Label.Text = $"Total Debt Owned: {newcustomer.TotalAmountOwed()}";



        }*/

        private void Dequeue_Click(object sender, EventArgs e)
        {
            if (!newcustomer.IsEmpty())
            {
                Customer remove_customer = newcustomer.Dequeue();
                textBox1.Text = remove_customer.GetInformation();
                Display_Info.Text = newcustomer.display();
            }
            else
            {
                MessageBox.Show("Customer Queue is empty. Cannot dequeue.");
                //Remove_Info.Clear();
                Total_Owed_Label.Text = " ";
                Customer_Max_Debt_Label.Text = "";
            }
       }

        private void Peek_Click(object sender, EventArgs e)
        {
            if (!newcustomer.IsEmpty()) 
            {
                Customer peekedCustomer = newcustomer.Peek();
               // Display(peekedCustomer);
                
            }
            else 
            {
                MessageBox.Show("Queue is empty. Cannot peek.");
            }   
        }
    }
}
