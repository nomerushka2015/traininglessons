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
            int integer_val = sizeof(int);
            int uint_val = sizeof(uint);
            int bool_val = sizeof(bool);
            int float_val = sizeof(float);
            int double_val = sizeof(double);
            int byte_val = sizeof(byte);
            int sbyte_val = sizeof(sbyte);
            int short_val = sizeof(short);
            int ushort_val = sizeof(ushort);
            int long_val = sizeof(long);
            int ulong_val = sizeof(ulong);

            Console.WriteLine("Размерность типа int" + "\t = " + integer_val);
            Console.WriteLine("Размерность типа uint" + "\t = " + uint_val);
            Console.WriteLine("Размерность типа bool" + "\t = " + bool_val);
            Console.WriteLine("Размерность типа float" + "\t = " + float_val);
            Console.WriteLine("Размерность типа double" + "\t = " + double_val);
            Console.WriteLine("Размерность типа byte" + "\t = " + byte_val);
            Console.WriteLine("Размерность типа sbyte" + "\t = " + sbyte_val);
            Console.WriteLine("Размерность типа short" + "\t = " + short_val);
            Console.WriteLine("Размерность типа ushort" + "\t = " + ushort_val);
            Console.WriteLine("Размерность типа long" + "\t = " + long_val);
            Console.WriteLine("Размерность типа ulong" + "\t = " + ulong_val);
            Console.Read();
        }
    }
}
