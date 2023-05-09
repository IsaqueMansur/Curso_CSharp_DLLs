using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriandoDLL;

namespace ConsumindoDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CriandoDLL.Mathematic.Sum(2, 2));
            Console.WriteLine(CriandoDLL.Mathematic.Multiply(2, 2));
        }
    }
}
