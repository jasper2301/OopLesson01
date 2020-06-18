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
            var lines = new List<string>
            {
                "おもしろい",
                "眠い",
                "寝る",
            };
            lines.Add("おやすみ");
            foreach (var s in lines)
            {
                Console.WriteLine(s);
            }
        }
        }
    }
