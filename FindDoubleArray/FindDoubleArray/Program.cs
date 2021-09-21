using System;

namespace FindDoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i} :\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }


            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        Console.WriteLine($"Совпадает {myArray[i]} \t");
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
