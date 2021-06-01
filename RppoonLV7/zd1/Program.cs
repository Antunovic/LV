using System;

namespace zd1
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[20];
            Random generator = new Random();
            for(int i = 0; i < 20; i++)
            {
                array[i] = generator.NextDouble() * 20;
            }
            NumberSequence numberSequence = new NumberSequence(array);
            
            numberSequence.SetSortStrategy(new BubbleSort());
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());

            numberSequence.SetSortStrategy(new SequentialSort());
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());

            numberSequence.SetSortStrategy(new CombSort());
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());





        }
    }


}
