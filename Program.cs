using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = {"Albert", "Kirsten", "Hester", "Henry"};

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i] + ", hello!");
            }
        }   
    }
}