using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {   //Below two lines are commented because they call the default constructor and I want to isolate to the statement calling the overloaded constructor that accepts the name as a parameter
            //Account CheckingAccountVariable1 = new Account();
            //CheckingAccountVariable1.AccountHolderName = "Casie";
            Account CheckingAccountVariable1 = new Account("Casie");
            Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
                CheckingAccountVariable1.AccountNumber, CheckingAccountVariable1.AccountHolderName, CheckingAccountVariable1.Balance);
            //CheckingAccount.AccountNumber = 10; //this is an example of what won't work because the set is a private set

            Account CheckingAccountVariable2 = new Account();
            CheckingAccountVariable2.AccountHolderName = "Brandon";
            Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
                CheckingAccountVariable2.AccountNumber, CheckingAccountVariable2.AccountHolderName, CheckingAccountVariable2.Balance);

        }
    }
}
