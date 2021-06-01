using System;

namespace zd2
{
    class LinearSearch : ISearchStrategy
    {

        public void Search(double[] array, double value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine("pronaden");
                }
            }

            Console.WriteLine("nema ga");
        }
    }
}
