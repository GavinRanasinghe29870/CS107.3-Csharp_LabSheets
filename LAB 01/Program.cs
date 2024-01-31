using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
            Console.ReadLine();
        }
            //QUESTION 01
            static void Question1()
            {
                Console.WriteLine("Enter Length");
                int l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Width");
                int w = Convert.ToInt32(Console.ReadLine());

                AreaCal(l, w);
            }

            static void AreaCal(int width, int height)
            {
                int area;
                area = width * height;
                Console.WriteLine("The area is: " + area);
            }

            //QUESTION 02

            static void Question2()
            {
                int[] num = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter number {0}", i);
                    if (int.TryParse(Console.ReadLine(), out num[i]))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Invlaid input");
                        i--;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    if (num[i] % 2 == 0)
                    {
                        Console.Write("Number {0}", num[i]);
                        Console.WriteLine(" is Even");
                    }
                    else
                    {
                        Console.Write("Number {0}", num[i]);
                        Console.WriteLine(" is Odd");
                    }
                }
            }

            //QUESTION 03

            static void Question3()
            {
                int sum = 0;
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("Sum = {0}", sum);
                }

            }

            //QUESTION 04
            static void Question4()
            {
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
            }

            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            //Question05
            static void Question5()
            {
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Multiplication table end number: ");
                int endNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                for (int i = 0; i < endNum; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i + 1, num, (i + 1) * num);
                }
            }

            //Question 06
            static void Question6()
            {
                string grade = "";

                Console.Write("Enter Your Name: ");
                string name = Console.ReadLine();

                int mark;

                while (true)
            {
                Console.WriteLine("Enter marks: ");
                mark = Convert.ToInt32(Console.ReadLine());

                if (mark >= 0 && mark <= 100)
                {
                    if (mark >= 75)
                    {
                        grade = "A";
                    }
                    else if (mark >= 60)
                    {
                        grade = "B";
                    }
                    else if (mark >= 50)
                    {
                        grade = "C";
                    }
                    else if (mark >= 40)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "Failed";
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("ERROR! Enter a valid mark between 0 and 100");
                }
            }

            Console.WriteLine("{0} {1}", name, grade);
        }

    }
    }

