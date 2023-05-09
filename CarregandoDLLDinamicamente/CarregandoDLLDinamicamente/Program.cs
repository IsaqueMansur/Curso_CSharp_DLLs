using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CarregandoDLLDinamicamente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly myDll = Assembly.LoadFile("C:\\Cursos\\C#_DLLs\\CriandoDLL\\CriandoDLL\\bin\\Debug\\CriandoDLL.dll");
            Type mathematicClass = myDll.GetType("CriandoDLL.Mathematic");
            dynamic instanceOfMathematic = Activator.CreateInstance(mathematicClass);
            var sumMethod = mathematicClass.GetMethod("Sum");
            double result = sumMethod.Invoke(instanceOfMathematic, new object[] {1 , 2 });
            Console.Write(result);
        }
    }
}
