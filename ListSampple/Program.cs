using System;
using System.Collections.Generic;

namespace ListSampple
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(7);

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
