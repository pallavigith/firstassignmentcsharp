using System;

namespace Firstassignmentcsharp
{
    class Program
    {
        public delegate void mydel();
        public class Bank
        {
            public event mydel Debit;
            public event mydel Credit;
            public int bal = 5000;
            public void Debit(int deb)
            {
                if (bal == 0)
                    Zero();
                else if (deb > bal)
                    Insufficient();
                bal = bal - deb;
                Console.WriteLine($"Total balance is{bal}");
            }
                public  void Credit(int credit)
                {
                    bal += credit;
                    Console.WriteLine($"Total Balance is {bal}");
                }
            }
            static void Zero()
            {
                Console.WriteLine("Balance is zero");
            }
            static void Insufficient()
            {
                Console.WriteLine("Balance is insufficeint");
            }
            static void Main(string[] args)
            {
                Bank bn = new Bank();
                bn.debit += new mydel(Zero);
                bn.debit += new mydel(Insufficient);
                bn.Debit(500);
            }
        }
    }
}
           
        }
    }

