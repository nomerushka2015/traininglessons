using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingOfSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = sizeof(int);
            int a = sizeof(bool);

            Console.WriteLine("Размерность типа int=" + i);
            Console.WriteLine("Размерность типа bool=" + a);
            Console.Read();
        }
    }
}
