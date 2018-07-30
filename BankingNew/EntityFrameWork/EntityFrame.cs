using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameWork
{
    class EntityFrame
    {
        static BankingEntities bankingEntities = new BankingEntities();
        public void AddEntity(string name, int id, string AccountType, int balance)
        {
            var bankE = new BankingEntities();
            Account_Info ob = new Account_Info();
            ob.Id = id;
            ob.Name = name;
            ob.AccountType = AccountType;
            ob.Balance = balance;
            bankE.Account_Info.Add(ob);
            bankE.SaveChanges();
        }

        public void Deposit(int id, int balance)
        {
            Account_Info ob = new Account_Info();
            int b_val = bankingEntities.Account_Info.Find(id).Balance;
            bankingEntities.Account_Info.Find(id).Balance = b_val + balance;


        }

        public void Withdrawl(int id, int amount)
        {
            Account_Info ob = new Account_Info();
            int b_val = bankingEntities.Account_Info.Find(id).Balance;
            string type = bankingEntities.Account_Info.Find(id).AccountType;
            if (type.Equals("Savings") && b_val - amount < 1000)
            {
                Console.Write("You can only withdraw " + (b_val - amount));
                Console.WriteLine("INSUFFICIENT BALANCE ");
            }
            else if (type.Equals("Current") && b_val - amount < 0)
            {
                Console.Write("You can only withdraw " + (b_val - amount));
                Console.WriteLine("INSUFFICIENT BALANCE ");
            }

            else if (type.Equals("DMAT") && b_val - amount < -1000)
            {
                Console.Write("You can only withdraw " + (b_val - amount));
                Console.WriteLine("INSUFFICIENT BALANCE ");
            }

            else
            {
                bankingEntities.Account_Info.Find(id).Balance = b_val + amount;
            }
        }

        public void Simple(int id)
        {
            Account_Info ob = new Account_Info();
            int b_val = bankingEntities.Account_Info.Find(id).Balance;
            string type = bankingEntities.Account_Info.Find(id).AccountType;
            if (type.Equals("Savings"))
            {
                Console.WriteLine(.01 * b_val);

            }
            else if (type.Equals("Current"))
            {
                Console.WriteLine(.01 * b_val);

            }
        }

        public void Display()
        {
            Account_Info ob = new Account_Info();
            List<Account_Info> lis = bankingEntities.Account_Info.ToList();
            for (int itr = 0; itr < lis.Count; itr++)
            {
                Console.WriteLine("Account-id {0}", lis[itr].Id);
                Console.WriteLine("Name {0}", lis[itr].Name);
                Console.WriteLine("Account Type {0}", lis[itr].AccountType);
                Console.WriteLine("Balance {0}", lis[itr].Balance);
            }

        }
    }
}
