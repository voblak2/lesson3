using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] groceryList = new string[4];
            groceryList[0] = "bread";
            groceryList[1] = "eggs";
            groceryList[2] = "milk";
            groceryList[3] = "tea";
            Console.WriteLine(groceryList[1]);
            groceryList[1] = "beans";
            Console.WriteLine(groceryList[1]);
        }   
    }
}