using System;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();

            ToDoItem lv6 = new ToDoItem("razvoj", "lv6", new DateTime(2021, 5, 16));
            //ToDoItem predrok = new ToDoItem("rppoon", "predrok", new DateTime(2021, 5, 22));

            careTaker.StoreSave(lv6.StoreState());

            lv6.Rename("neam pojma");

            Console.WriteLine(lv6.ToString());

            lv6.RestoreState(careTaker.PreviousState);

            Console.WriteLine(lv6.ToString());

           
        }
    }
}
