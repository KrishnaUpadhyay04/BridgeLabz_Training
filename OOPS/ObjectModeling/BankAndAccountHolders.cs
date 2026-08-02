using System;

namespace ObjectModeling.Bank
{
    class Bank
    {
        public string BankName;

        public void OpenAccount(Customer customer)
        {
            customer.bank = this;
            Console.WriteLine($"Account opened for {customer.CustomerName} in {BankName}");
        }
    }

    class Customer
    {
        public string CustomerName;
        public double Balance;
        public Bank bank;

        public Customer(string CustomerName, double Balance)
        {
            this.CustomerName = CustomerName;
            this.Balance = Balance;
        }

        private void SetBalanace(double amount)
        {
            Balance = amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Balace:  {Balance}");
        }
    }
}