using System;

namespace simpleprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num1, num2;
            //int res;
            //num1 = Convert.ToDouble(Console.ReadLine());
            //num2 = Convert.ToDouble(Console.ReadLine());
            //res =(int)( num1 + num2);
            //Console.WriteLine("The result is "+res);
            //Console.ReadLine();
            //int num, sum = 0,rem,number;
            //num = Convert.ToInt32(Console.ReadLine());
            //number = num;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    sum =rem*rem*rem+sum;
            //    num = num / 10;
            //}
            //if (sum == number)
            //{
            //    Console.WriteLine("The result is " + sum);
            //}
            //else
            //{
            //    Console.WriteLine("not arm");
            //}
            //

            //int num, sum = 0;
            //num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num / 2; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //if (sum == num)
            //{
            //    Console.WriteLine("Perfect Number");
            //}
            //else
            //{
            //    Console.WriteLine(" Not an Perfect Number");
            //}
            /*
            Console.WriteLine("consumer_number : ");
           int consumer_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("consumer_name : ");
            string consumer_name = Console.ReadLine();
            Console.WriteLine("prev_reading : ");
            int prev_reading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("curreading : ");
            int curreading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("consumer_type : ");
            string consumer_type = Console.ReadLine();//string ? means take null valuesconsumer_number, consumer_name, prev_reading, curreading, consumer_type
            */
            //ElectricReading electricReading = new ElectricReading(100, "kiruba", 200, 400, "Commercial");
            //electricReading.ReadConsumerData();
            //int billamt = electricReading.CalculateBill();
            //electricReading.DisplayBillDetails();
            //Console.WriteLine($"Bill : " + $"{ electricReading.Consumer_number}" + $" { electricReading.Consumer_name } " + $"{ billamt }");//string interpolation value



            Console.WriteLine("acc_name : ");
            string acc_holder_name = Console.ReadLine();
            Console.WriteLine("dep_amount ");
             int dep_amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("withdraw amount :  ");
            int withdraw_Amt = Convert.ToInt32(Console.ReadLine());


            BankAccount bankAccount =new BankAccount(acc_holder_name);
            
            bankAccount.Deposit(dep_amount);
            bankAccount.Withdraw(withdraw_Amt);
            bankAccount.Display();
            Console.ReadLine();


        }
    }
}
