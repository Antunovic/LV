using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[20];
            Random generator = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = generator.NextDouble() * 20;
            }
            NumberSequence numberSequence = new NumberSequence(array);

            numberSequence.SetSearchStrategy(new LinearSearch());
            numberSequence.Search(3.2);
        }
    }
}
