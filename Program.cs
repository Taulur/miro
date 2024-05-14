using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable repeats = new Hashtable();
            List<double> newarray = new List<double>();
            string[] array = { "5", "2", "10", "5", "10", "11" };
            foreach (string i in array)
            {
                Console.Write(i + " ");
                int repeat = 0;
                foreach (string j in array)
                {
                    if (i == j)
                    {
                        repeat++;
                    }
                }
                if (!repeats.ContainsKey(i))
                {
                    repeats.Add(i, repeat);
                }
            }
            Console.WriteLine();
            foreach (string i in repeats.Keys)
            {
                newarray.Add(Convert.ToDouble(i) * Convert.ToDouble(repeats[i]));
            }
            foreach (double i in newarray)
            {
                Console.Write(i + " ");
            }

        }
    }
}
