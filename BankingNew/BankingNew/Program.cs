﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic1;
namespace BankingNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int id = 1, balance, flag = 0;
            string name, AccountType;
            Console.WriteLine("Choose a type of framework\nPress 1 for Adot\nPress 2 for Entity");
            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                Blogic blog = new Blogic();

                Console.WriteLine("Banking System\n");
                Console.WriteLine("Enter the Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the Account Type:\nSavings\nCurrent\nDMAT");
                AccountType = Console.ReadLine();
                Console.WriteLine("Enter the balance you want to add");
                balance = int.Parse(Console.ReadLine());
                blog.DataEntry(name, ++id, AccountType, balance);
                Console.WriteLine("Account has been added");
                while (true)
                {
                    Console.WriteLine("\nFor more functions\nPress 1 for Display\nPress 2 for Deposit\nPress 3 for Withdrawl\nPress 4 to add account\nPress 5 to show Simple Interest\nPress 6 for exit");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            blog.Display();
                            break;
                        case 2:
                            Console.WriteLine("Enter your ID");
                            int id1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the amount you want to deposit");
                            int balance1 = int.Parse(Console.ReadLine());
                            blog.Deposit(id1, balance1);
                            break;

                        case 3:
                            Console.WriteLine("Enter your ID");
                            id1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the amount you want to withdraw");
                            balance1 = int.Parse(Console.ReadLine());
                            blog.Withdrawl(id1, balance1);
                            break;
                        case 4:
                            Console.WriteLine("Enter the Name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the Account Type:\nSavings\nCurrent\nDMAT");
                            AccountType = Console.ReadLine();
                            Console.WriteLine("Enter the balance you want to add");
                            balance = int.Parse(Console.ReadLine());
                            blog.DataEntry(name, ++id, AccountType, balance);
                            break;
                        case 5:
                            Console.WriteLine("Enter your ID");
                            id1 = int.Parse(Console.ReadLine());
                            blog.Simple(id1);
                            break;

                        default:
                            Console.WriteLine("Bye Bye");
                            flag = 1;
                            break;
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
            }

            else
            {
                id = 101;

                Eblogic Eblog = new Eblogic();
                //Console.WriteLine("Banking System\n");
                //Console.WriteLine("Enter the Name");
                //name = Console.ReadLine();
                //Console.WriteLine("Enter the Account Type:\nSavings\nCurrent\nDMAT");
                //AccountType = Console.ReadLine();
                //Console.WriteLine("Enter the balance you want to add");
                //balance = int.Parse(Console.ReadLine());
                //Eblog.AddEntity(name, id, AccountType, balance);
                //id++;
                Console.WriteLine("Account has been added");
                while (true)
                {
                    Console.WriteLine("\nFor more functions\nPress 1 for Display\nPress 2 for Deposit\nPress 3 for Withdrawl\nPress 4 to add account\nPress 5 to show Simple Interest\nPress 6 for exit");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Eblog.Display();
                            break;
                        case 2:
                            Console.WriteLine("Enter your ID");
                            int id1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the amount you want to deposit");
                            int balance1 = int.Parse(Console.ReadLine());
                            Eblog.Deposit(id1, balance1);
                            break;

                        case 3:
                            Console.WriteLine("Enter your ID");
                            id1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the amount you want to withdraw");
                            balance1 = int.Parse(Console.ReadLine());
                            Eblog.Withdrawl(id1, balance1);
                            break;
                        case 4:
                            Console.WriteLine("Enter the Name");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the Account Type:\nSavings\nCurrent\nDMAT");
                            AccountType = Console.ReadLine();
                            Console.WriteLine("Enter the balance you want to add");
                            balance = int.Parse(Console.ReadLine());
                            Eblog.AddEntity(name, ++id, AccountType, balance);
                            break;
                        case 5:
                            Console.WriteLine("Enter your ID");
                            id1 = int.Parse(Console.ReadLine());
                            Eblog.Simple(id1);
                            break;

                        default:
                            Console.WriteLine("Bye Bye");
                            flag = 1;
                            break;
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
            }

        }
    }
}
