using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Bank_Console_Application
{
    class Bank
    {
        private double balance = 10000;
        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }

    }
    class  TestBank
        {
            Bank Wema = new Bank();
            string name;
            int account;
            double withdraw, deposit, total;

            public void ReceiveMoney()
            {
                Console.WriteLine("Enter Name of depositor:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number:");
                account = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Deposit Amount:");
                deposit = Convert.ToDouble(Console.ReadLine());
                total = Wema.bal + deposit;

                Console.WriteLine("*********************\n");
                Console.WriteLine("Name of depositior: " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Total  Balance amount in the account: " + total);
                
            }

            public void SendMoney()
            {
                Console.WriteLine("Emter Account Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number: ");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount: ");
                withdraw = Convert.ToDouble(Console.ReadLine());
                if(withdraw <= Wema.bal)
                {
                    total = Wema.bal - withdraw;
                    Console.WriteLine("******************");
                    Console.WriteLine("Account Name: " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("After Withdraw Amount balance is : " + total);

                }
                else
                {
                    Console.WriteLine("Cannot Withdraw as amount is not enough!");
                }
            }

            public double CheckBalance()
            {
                return Wema.bal;
            }
            
        }

   
}
