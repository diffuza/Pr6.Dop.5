using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 455, i2 = 84500; //присвоение локальным переменным i1,i2 целочисленое значение "int".
            decimal dec = 7.98845m;// присвоение локальной переменной "dec" финансового типа "decimal".
                      
            Console.WriteLine((short)i1);// Приводим число типа int к типу short.
            Console.WriteLine((short)i2);// Приводим число типа int к типу short.
                     
            Console.WriteLine((int)dec); // приводим число типа "decimal" к типу "int".

            Console.ReadLine(); //чтение вычисляемых данных.
        }
    }
}