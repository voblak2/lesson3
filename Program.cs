using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 1;

            do
            {
                Console.WriteLine(myNumber);
                myNumber++;
            } while (myNumber < 10);
        }   
    }
}