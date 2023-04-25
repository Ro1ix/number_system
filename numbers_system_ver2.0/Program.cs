using System;
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

            if (system_1 < 2 || system_1 > 16 || system_2 < 2 || system_2 > 16)
                Console.WriteLine("\nОШИБКА Попробуйте ещё раз");
            else
            {
                int length = number.Length; /*Находим длину нашего числа*/
                int[] array = new int[length]; /*Объявляем массив, в который будет записываться наше чило*/
                for (int i = 0; i < length; i++)
                {
                    switch (number[i])
                    {
                        case '0':
                            array[i] = 0;
                            break;
                        case '1':
                            array[i] = 1;
                            break;
                        case '2':
                            array[i] = 2;
                            break;
                        case '3':
                            array[i] = 3;
                            break;
                        case '4':
                            array[i] = 4;
                            break;
                        case '5':
                            array[i] = 5;
                            break;
                        case '6':
                            array[i] = 6;
                            break;
                        case '7':
                            array[i] = 7;
                            break;
                        case '8':
                            array[i] = 8;
                            break;
                        case '9':
                            array[i] = 9;
                            break;
                        case 'A':
                            array[i] = 10;
                            break;
                        case 'B':
                            array[i] = 11;
                            break;
                        case 'C':
                            array[i] = 12;
                            break;
                        case 'D':
                            array[i] = 13;
                            break;
                        case 'E':
                            array[i] = 14;
                            break;
                        case 'F':
                            array[i] = 15;
                            break;
                        default:
                            Console.WriteLine("Ошибка, попробуйте снова");
                            break;
                    }
                }

                int ten = 0; /*Объявляем переменную, в которую будет записываться число в десятичной системе счисления*/
                for (int i = 0; i < array.Length; i++)
                {
                    length--;
                    ten = ten + array[i] * (int)Math.Pow(system_1, length);
                }

                int help = ten;
                int count = 1;
                while (help >= system_2)
                {
                    help = help / system_2;
                    count++;
                }

                int[] array2 = new int[count];
                string answer = "";
                for (int i = 0; ten >= system_2; i++)
                {
                    array2[i] = ten % system_2;
                    ten = ten / system_2;
                }
                array2[count - 1] = ten % system_2;
                for (int i = count - 1; i >= 0; i--)
                {
                    switch (array2[i])
                    {
                        case 0:
                            answer = answer + '0';
                            break;
                        case 1:
                            answer = answer + '1';
                            break;
                        case 2:
                            answer = answer + '2';
                            break;
                        case 3:
                            answer = answer + '3';
                            break;
                        case 4:
                            answer = answer + '4';
                            break;
                        case 5:
                            answer = answer + '5';
                            break;
                        case 6:
                            answer = answer + '6';
                            break;
                        case 7:
                            answer = answer + '7';
                            break;
                        case 8:
                            answer = answer + '8';
                            break;
                        case 9:
                            answer = answer + '9';
                            break;
                        case 10:
                            answer = answer + 'A';
                            break;
                        case 11:
                            answer = answer + 'B';
                            break;
                        case 12:
                            answer = answer + 'C';
                            break;
                        case 13:
                            answer = answer + 'D';
                            break;
                        case 14:
                            answer = answer + 'E';
                            break;
                        case 15:
                            answer = answer + 'F';
                            break;
                        default:
                            Console.WriteLine("Ошибка, попробуйте снова");
                            break;
                    }
                }
                Console.WriteLine($"\nОтвет: {answer}");
            }
        }
    }
}
