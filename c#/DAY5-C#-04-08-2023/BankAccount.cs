using System;
using System.Collections.Generic;
using System.Text;

namespace simpleprograms
{
    class BankAccount
    {
        private readonly int acc_number;
        private int balance;
        private string acc_holder_name;

        public BankAccount(string acc_holder_name)
        {
            acc_number = 123456;
            Acc_holder_name = acc_holder_name;
            Balance = 0;
            
        }

        public int Acc_number => acc_number;

        public int Balance { get => balance; set => balance = value; }
        public string Acc_holder_name { get => acc_holder_name; set => acc_holder_name = value; }

        public void Deposit(int dep_amount)
        {
            if(dep_amount<=0)
            {
                Console.WriteLine("inadequate amount");
            }
            else
            {
               Balance = dep_amount + Balance;
            }
        }
        public void Withdraw(int withdraw_amt)
        {
            if(withdraw_amt<=0)
            {
                Console.WriteLine("Zero balance");
            }
            else if (Balance>= withdraw_amt)
            {
                Balance = Balance - withdraw_amt;
            }
            else
            {
                Console.WriteLine("please enter amount correctly");
            }
        }
        public void Display()
        {
            Console.WriteLine("Acc Number : " + Acc_number);
            Console.WriteLine("Acc Holder Name:" + Acc_holder_name);
            Console.WriteLine("Balance:" + Balance);

        }
    }
}
