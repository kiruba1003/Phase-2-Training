using System;
using System.Collections.Generic;
using System.Text;

namespace simpleprograms
{
    class ElectricReading
    {
        private int curreading;
        string consumer_name, consumer_type;
        private int consumer_number;
        private int prev_reading;

        //public void ReadConsumerData()
        //{
        //    Console.WriteLine("consumer_number : ");
        //    consumer_number = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("consumer_name : ");
        //    consumer_name = Console.ReadLine();
        //    Console.WriteLine("prev_reading : ");
        //    prev_reading = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("curreading : ");
        //    curreading = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("consumer_type : ");
        //    consumer_type = Console.ReadLine();
        //}
        public ElectricReading(int consumer_number, string consumer_name, int prev_reading, int curreading, string consumer_type)
        {
            this.Consumer_number = consumer_number;
            this.Consumer_name = consumer_name;
            this.Prev_reading = prev_reading;
            this.Curreading = curreading;
            this.Consumer_type = consumer_type;
        }

        public int Consumer_number { get => consumer_number; set => consumer_number = value; }
        public int Prev_reading { get => prev_reading; set => prev_reading = value; }
        public int Curreading { get => curreading; set => curreading = value; }
        public string Consumer_name { get => consumer_name; set => consumer_name = value; }
        public string Consumer_type { get => consumer_type; set => consumer_type = value; }

        public int CalculateBill()
        {
            
            int billamt = 0;
            int consumption = Curreading - Prev_reading;
            if (Consumer_type.Equals("Domestic"))
            {

                if (consumption <= 100)
                {
                    billamt = 0;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption - 100) * 10;
                }
            }
            else if (Consumer_type.Equals("Commercial"))
            {
                if (consumption <= 100)
                {
                    billamt = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 50;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption - 100) * 100;
                }
            }
            return billamt;

        }
        //public void DisplayBillDetails()
        //{
        //    int billamt = CalculateBill();
        //    Console.WriteLine($"Bill : " +$"{ consumer_number} { consumer_name } { billamt }");//string interpolation value
        //    Console.ReadLine();
        //}

    }
}
