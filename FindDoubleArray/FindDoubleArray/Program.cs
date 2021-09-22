using System;
using System.Collections.Generic;
using System.Linq;



namespace FindDoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            var nums = Enumerable.Range(1, elementsCount).ToList();

            int[] result = new int[elementsCount + 1];

            Random rand = new Random();

            for (int i = 0; i < elementsCount; i++)
            {
                int pos = rand.Next(0,nums.Count);
                result[i] = nums[pos];
                nums.RemoveAt(pos);
            }
            int randpos = rnd.Next(elementsCount);
            for (int i = elementsCount-1; i >= randpos; i--)
            {
                result[i + 1] = result[i];
            }

            result[randpos] = rnd.Next(1,elementsCount);

            foreach (var i in result)
            {
                Console.Write(" " + i);
            }
            

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (result[i] == result[j])
                    {
                        Console.WriteLine($" Совпадает {result[i]} ");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
