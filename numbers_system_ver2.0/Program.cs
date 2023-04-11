﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_system_ver2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРЕВОД ЧИСЛА ИЗ ОДНОЙ СИСТЕМЫ СЧИСЛЕНИЯ В ДРУГУЮ");
            Console.WriteLine("\nВведите число, над которым будет проводиться операция");
            string number = Console.ReadLine(); /*Вводим наше число. Тип данных string, потому что есть системы счисления с буквами*/

            Console.WriteLine("\nВведите систему счисления этого числа (от 2 до 16)");
            int system_1 = Convert.ToInt32(Console.ReadLine()); /*Вводим систему счисления, в которой находится наше число*/

            Console.WriteLine("\nВведите систему счисления, в которую хотите перевести число (от 2 до 16)");
            int system_2 = Convert.ToInt32(Console.ReadLine()); /*Вводим систему счисления, в которую хотим перевести наше число*/




            int length = number.Length; /*Находим длину нашего числа*/
            int ten = 0; /*Объявляем переменную, в которую будет записываться число в десятичной системе счисления*/
            int number = Convert.ToInt32(number);
            while (length > 0)
            {
                length--;
                ten = ten + (int)(number / Math.Pow(10, length)) * (int)(Math.Pow(system_2, length));
            }
        }
    }
}
