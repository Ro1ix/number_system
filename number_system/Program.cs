using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРЕВОД ЧИСЛА ИЗ ОДНОЙ СИСТЕМЫ СЧИСЛЕНИЯ В ДРУГУЮ");
            Console.WriteLine("\nВведите число, над которым будет проводиться операция");
            string number = Console.ReadLine();
            Console.WriteLine("\nВведите систему счисления этого числа (от 2 до 16)");
            int system1 = Convert.ToInt32(Console.ReadLine());
            if ((system1 >= 2) & (system1 <= 16))
            {
                Console.WriteLine("\nВведите систему счисления, в которую хотите перевести число (от 2 до 16)");
                int system2 = Convert.ToInt32(Console.ReadLine());
                if ((system2 >= 2) & (system2 <= 16))
                {
                    Console.Write("\nОтвет: ");
                    int notanswer = 0;
                    switch (system1)
                    {
                        case 10:
                            int numb = Int32.Parse(number);
                            string f = "";
                            string answer = "";
                            if (system1 == 10)
                            {
                                while (numb > 0)
                                {
                                    int ostatok = numb % system2;
                                    numb /= system2;
                                    if (ostatok == 10)
                                    {
                                        string bukva = "A";
                                        answer = bukva + answer;
                                    }
                                    else
                                    {
                                        if (ostatok == 11)
                                        {
                                            string bukva = "B";
                                            answer = bukva + answer;
                                        }
                                        else
                                        {
                                            if (ostatok == 12)
                                            {
                                                string bukva = "C";
                                                answer = bukva + answer;
                                            }
                                            else
                                            {
                                                if (ostatok == 13)
                                                {
                                                    string bukva = "D";
                                                    answer = bukva + answer;
                                                }
                                                else
                                                {
                                                    if (ostatok == 14)
                                                    {
                                                        string bukva = "E";
                                                        answer = bukva + answer;
                                                    }
                                                    else
                                                    {
                                                        if (ostatok == 15)
                                                        {
                                                            string bukva = "F";
                                                            answer = bukva + answer;
                                                        }
                                                        else
                                                        {
                                                            f = ostatok.ToString();
                                                            answer = f + answer;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                Console.WriteLine(answer);

                            }
                            else
                            {
                                while (notanswer > 0)
                                {
                                    int ostatok = notanswer % system2;
                                    notanswer /= system2;
                                    if (ostatok == 10)
                                    {
                                        string bukva = "A";
                                        answer = bukva + answer;
                                    }
                                    else
                                    {
                                        if (ostatok == 11)
                                        {
                                            string bukva = "B";
                                            answer = bukva + answer;
                                        }
                                        else
                                        {
                                            if (ostatok == 12)
                                            {
                                                string bukva = "C";
                                                answer = bukva + answer;
                                            }
                                            else
                                            {
                                                if (ostatok == 13)
                                                {
                                                    string bukva = "D";
                                                    answer = bukva + answer;
                                                }
                                                else
                                                {
                                                    if (ostatok == 14)
                                                    {
                                                        string bukva = "E";
                                                        answer = bukva + answer;
                                                    }
                                                    else
                                                    {
                                                        if (ostatok == 15)
                                                        {
                                                            string bukva = "F";
                                                            answer = bukva + answer;
                                                        }
                                                        else
                                                        {
                                                            f = ostatok.ToString();
                                                            answer = f + answer;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                Console.WriteLine(answer);
                            }
                            break;
                        default:
                            int lenght = number.Length;
                            char[] arr = number.ToCharArray();
                            int a = 0;
                            int b;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                lenght--;
                                switch (arr[i])
                                {
                                    case '0':
                                        a = 0;
                                        break;
                                    case '1':
                                        a = 1;
                                        break;
                                    case '2':
                                        a = 2;
                                        break;
                                    case '3':
                                        a = 3;
                                        break;
                                    case '4':
                                        a = 4;
                                        break;
                                    case '5':
                                        a = 5;
                                        break;
                                    case '6':
                                        a = 6;
                                        break;
                                    case '7':
                                        a = 7;
                                        break;
                                    case '8':
                                        a = 8;
                                        break;
                                    case '9':
                                        a = 9;
                                        break;
                                    case 'A':
                                        a = 10;
                                        break;
                                    case 'B':
                                        a = 11;
                                        break;
                                    case 'C':
                                        a = 12;
                                        break;
                                    case 'D':
                                        a = 13;
                                        break;
                                    case 'E':
                                        a = 14;
                                        break;
                                    case 'F':
                                        a = 15;
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                        break;
                                }
                                b = (int)Math.Pow(16, lenght);
                                notanswer += a * b;
                            }
                            if (system2 == 10)
                                Console.WriteLine(notanswer);
                            else
                            {
                                number = notanswer.ToString();
                                goto case 10;
                            }
                            break;
                    }
                }
                else Console.WriteLine("\nТакая система счисления не подходит!");
            }
            else Console.WriteLine("\nТакая система счисления не подходит!");
        }
    }
}
