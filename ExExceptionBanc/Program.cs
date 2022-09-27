using System;
using System.Globalization;
using ExExceptionBanc.Entities;
using ExExceptionBanc.Entities.Exceptions;

namespace ExExceptionBanc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double wlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account holder = new Account(number,name,balance,wlimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                holder.Withdraw(withdraw);
                Console.WriteLine("New balance: " + holder);
            }
            catch(AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            
        }
    }
}
