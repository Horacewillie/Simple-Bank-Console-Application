using System;

namespace Simple_Bank_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            char run;
            do
            {
                TestBank Wema = new TestBank();
                int num;
                Console.WriteLine("Please Select an Action");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 to Withdraw an Amount. \nPress 3 to Chcek Balance");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Wema.ReceiveMoney();
                        break;
                    case 2:
                        Wema.SendMoney();
                        break;
                    case 3:
                        Wema.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                run = Convert.ToChar(Console.ReadLine());
            }
            while (run == 'y');

            Console.ReadKey();
        }
    }
}
