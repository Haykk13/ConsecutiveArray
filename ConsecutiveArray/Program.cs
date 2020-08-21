using System;

namespace ConsecutiveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter statues quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            int[] array = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Enter the value: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The quantity of missing elements is {makeArrayConsecutive2(array)}!");
            Console.ReadLine();
        }
        static int makeArrayConsecutive2(int[] statues)
        {
            int max = statues[0];
            int min = statues[0];
            for (int i = 1; i < statues.Length; i++)
            {
                if(statues[i] > max)
                {
                    max = statues[i];
                }
                if(statues[i] < min)
                {
                    min = statues[i];
                }
            }
            int result = max - min + 1 - statues.Length;
            return result;
        }
    }
}
