using System;

namespace zd4
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();

            BankAccount Antunovic1 = new BankAccount("antunovic", "bbbbbbb", 15000);
            BankAccount Antunovic2 = new BankAccount("antunovic2", "aaa", 1);

            careTaker.AddState(Antunovic1.StoreState());
            careTaker.AddState(Antunovic2.StoreState());

            Antunovic2.UpdateBalance(1000);

            Console.WriteLine(Antunovic2.ToString());

            Antunovic2.RestoreState(careTaker.PreviousState);

            Console.WriteLine(Antunovic2.ToString());

        }
    }
}
