using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCount<int> count1 = new BankCount<int>();
            count1.Count = 654789;
            count1.Balance = 589478.07;
            count1.Write();
            count1.Read();
            Console.WriteLine();

            BankCount<double> count2 = new BankCount<double>();
            count2.Count = 654789.5825;
            count2.Balance = 3589752.01;
            count2.Write();
            count2.Read();
            Console.WriteLine();

            BankCount<string> count3 = new BankCount<string>();
            count3.Count = "LD589657";
            count3.Balance = 45785631.58;
            count3.Write();
            count3.Read();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
    class BankCount<T>
    {
        double balance;
        T count;
        string name;

        public T Count
        {
            set
            {
                count = value;
            }
            get
            {
                return count;
            }
        }
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }

        }
        public void Write()
        {
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
        }
        public void Read()
        {
            Console.WriteLine("Владелец {0}", name);
            Console.WriteLine("Номер счета {0}", count);
            Console.WriteLine("Баланс {0}", balance);
        }
    }
}
