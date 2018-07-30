using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrame1;
using DatabaseConnect1;

namespace BusinessLogic1
{
    public class Blogic
    {


        public Db DataVal = new Db();
        public void DataEntry(string name, int id, string AccountType, int balance)
        {

            DataVal.ExecutionEntry(name, ++id, AccountType, balance);

        }

        public void Display()
        {
            DataVal.ExecutionDisplay();
        }

        public void Deposit(int id, int balance)
        {
            DataVal.ExecutionDeposit(id, balance);
        }

        public void Withdrawl(int id, int balance)
        {
            DataVal.ExecutionWithdrawl(id, balance);
        }

        public void Simple(int id)
        {
            DataVal.SimpleInterest(id);
        }
    }


    public class Eblogic
    {
        public EntityFrame Edata = new EntityFrame();
        public void AddEntity(string name, int id, string AccountType, int balance)
        {
            Edata.AddEntity(name, ++id, AccountType, balance);
        }

        public void Deposit(int id, int balance)
        {
            Edata.Deposit(id, balance);
        }

        public void Withdrawl(int id, int balance)
        {
            Edata.Withdrawl(id, balance);
        }

        public void Simple(int id)
        {
            Edata.Simple(id);
        }

        public void Display()
        {
            Edata.Display();
        }
    }
}
