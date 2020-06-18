using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
