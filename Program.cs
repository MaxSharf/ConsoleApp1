using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
             //Program1();
           //Program2();
            //Program3();
            //Program4();
            Program5();
            //Program6();
            //Program7();
            Console.OutputEncoding = Encoding.Unicode;
            Console.ReadKey(true);

        }

        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Console.Write( prompt);
                string str = Console.ReadLine();
                if (int.TryParse(str, out int value))
                {
                    return value;
                }
                Console.WriteLine("\t\tПомилка введення!!!");
            }
        }

        static void Program1()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = i.ToString();
                if (i % 3 == 0)
                {
                    result = "Fizz";
                    if (i % 5 == 0) result = "FizzBuzz";
                }
                else if (i % 5 == 0) result = "Buzz";
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }




    

        static void Program2()
        {
            Console.WriteLine("Введіть число ");
            double ch = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть відсоток ");
            double vid = Convert.ToInt16(Console.ReadLine());

            double sum;
            sum = (ch * vid) / 100;

            Console.WriteLine($"\t{vid} Відводків від {ch} дорівнює {sum} ");
        }

        static void Program3()
        {

            Console.WriteLine("Введіть число 1 ");
            double ch1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 2 ");
            double ch2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 3 ");
            double ch3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 4 ");
            double ch4 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Числа {ch1}{ch2}{ch3}{ch4}" );
            
        }

        static void Program4()
        {

            int a1, a2, a3, a4, a5, a6;
            Console.WriteLine("Введіть  Першу цифру шістезначного числа ");
            a1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Другу цифру шістезначного числа ");
            a2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Третю цифру шістезначного числа ");
            a3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Четверту цифру шістезначного числа ");
            a4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  П'яту цифру шістезначного числа ");
            a5 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Шосту цифру шістезначного числа ");
            a6 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Ваше число {a1}{a2}{a3}{a4}{a5}{a6}");

            Console.WriteLine("Введіть номер пари чисел які б ви хотіли поміняти містями");
        }


        static void Program5()
        {
            int a, b;
            string p = "", p1 = "" ;
            a = EnterInt32("Введіть день місяця -");
            b = EnterInt32("Введіть номер місяця -");

            if (a > 0 || a < 32)
            {
                switch (a)
                {
                    case 1: p = "Friday "; break;
                    case 2: p = "Saturday "; break;
                    case 3: p = "Sunday "; break;
                    case 4: p = "Monday "; break;
                    case 5: p = "Tuesday "; break;
                    case 6: p = "Wednesday "; break;
                    case 7: p = "Thursday "; break;
                    case 8: p = "Friday "; break;
                    case 9: p = "Saturday "; break;
                    case 10: p = "Sunday "; break;
                    case 11: p = "Monday "; break;
                    case 12: p = "Thursday "; break;
                    case 13: p = "Wednesday "; break;
                    case 14: p = "Friday "; break;
                    case 15: p = "Saturday "; break;
                    case 16: p = "Sunday "; break;
                    case 17: p = "Monday "; break;
                    case 18: p = "Tuesday "; break;
                    case 19: p = "Wednesday"; break;
                    case 20: p = "Thursday"; break;
                    case 21: p = "Friday"; break;
                    case 22: p = "Saturday"; break;
                    case 23: p = "Sunday"; break;
                    case 24: p = "Monday"; break;
                    case 25: p = "Tuesday"; break;
                    case 26: p = "Wednesday"; break;
                    case 27: p = "Thursday"; break;
                    case 28: p = "Friday"; break;
                    case 29: p = "Saturday"; break;
                    case 30: p = "Sunday"; break;
                    case 31: p = "Monday"; break;

                }
            }
            if (b >= 1 || b < 13 )
            {
                switch (b)
                {
                    case 1: p1 = " January . Winter "; break;
                    case 2: p1 = " February . Winter "; break;
                    case 3: p1 = "March  .Spring "; break;
                    case 4: p1 = "April . Spring "; break;
                    case 5: p1 = "May . Spring "; break;
                    case 6: p1 = "June . Summer "; break;
                    case 7: p1 = "July . Summer "; break;
                    case 8: p1 = "August .Summer "; break;
                    case 9: p1 = "Semtember . Autumn "; break;
                    case 10: p1 = "Oclober . Autumn "; break;
                    case 11: p1 = "November . Autumn "; break;
                    case 12: p1 = "December . Winter "; break;
                }
                Console.WriteLine($"{p1} .{p}");

            }



        }

        static void Program6()
        {

            Console.WriteLine("Enteer temperature");
            double a;
        a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose how to convertate 1.Cels to Far 2.Far to Cel");
            int choice;
        choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double result = a * 1.8 + 32;
                    Console.WriteLine($"Farengeith: {result}");
                    break;

                case 2:
                    double resultt = (a - 32) / 1.8;
                    Console.WriteLine($"Celsium: {resultt}");
                    break;
            }
        }

        static void Program7()
        {
            int a1,  a2;
            const int v = 1;
            Console.WriteLine("Введіть перше  число :");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге  число :");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Чотні числа в діапазоні між {a1} та {a2} =");
            if (a1 < a2)
            {
                int size = a2 - a1;
                for (int i = a1; i < size; i++)
                {

                    int n = i + 2;
                    int n1 = n % 2;
                    if (n1 != v)
                    {
                        Console.Write($"\t{i} ");

                    }

                }
            }
            else if (a1 > a2)
            {
                int size = a1 - a2;
                for (int i = a2; i < size; i++)
                {

                    int n = i + 2;
                    int n1 = n % 2;

                    if (n1 != v)
                    {
                        Console.Write($"{i} \t");

                    }

                }

            }
            else
            {
                Console.WriteLine($"Eror user");
            }

        }

    }
    }

