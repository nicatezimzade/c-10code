using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercise1
            //            while (true)
            //            {
            //                try
            //                {
            //                    Console.WriteLine("balinizi daxil edin: ");
            //                    int point = Convert.ToInt32(Console.ReadLine());
            //                    if (point <= 100 && point >= 91) 
            //                    {
            //                        Console.WriteLine("A");
            //                        break;
            //                    }
            //                    else if (point <= 90 && point >= 81)
            //                    {
            //                        Console.WriteLine("B");
            //                        break;
            //                    }
            //                    else if (point <= 80 && point >= 71)
            //                    {
            //                        Console.WriteLine("C");
            //                        break;
            //                    }
            //                    else if (point <= 70 && point >= 61)
            //                    {
            //                        Console.WriteLine("D");
            //                        break;
            //                    }
            //                    else if (point <= 60 && point >= 51)
            //                    {
            //                        Console.WriteLine("E");
            //                        break;
            //                    }
            //                    else if (point <= 50 && point >= 0) 
            //                    {
            //                        Console.WriteLine("kesr");
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("error");
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    Console.WriteLine("balinizi duzgun daxil edin !");
            //                }

            //            }
            #endregion
            #region exercise2

            //Console.WriteLine("ededi daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int dividers = 1;
            //while (dividers<=number)

            //{
            //    if (number%dividers==0)
            //    {
            //        Console.WriteLine(dividers);
            //        dividers++;
            //    }
            //    else
            //    {
            //        dividers++;
            //    }
            //}
            #endregion
            #region exercise3

            //            Console.WriteLine("eded daxil edin: ");
            //            int num = Convert.ToInt32(Console.ReadLine());
            //            int floor = 1;

            //            while ( num >= 10 )
            //            {
            //                num /= 10;
            //                floor++;
            //            }
            //            Console.WriteLine(floor);
            #endregion
            #region exercise4

            //Console.WriteLine("ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //while (num>=1)
            //{
            //    result += num % 10;
            //    num = (num - (num % 10)) / 10;
            //}
            //Console.WriteLine(result);



            #endregion
            #region exercise5

            //static bool Simpleness(int x, int i=2)
            //{
            //    while (x>1)
            //    {
            //        if (x%i==0 && x>i)
            //        {
            //            return false;
            //        }
            //        else
            //        {
            //        i++;
            //        }
            //        return true;
            //    }
            //    return true;
            //}
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("eded daxil edin: ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Simpleness(x));
            #endregion
            #region exercise6
            //static int Factorial(int num, int result=1)
            //{

            //    while (num>=1)
            //    {
            //        result *= num;
            //        num--;
            //    }
            //    return result;

            //}
            //static void Main(string[] args)
            //    {
            //        Console.WriteLine("eded daxil edin: ");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(Factorial(num));
            #endregion
            #region exercise7

            //int[] nums = new int[10];
            //int smallest = nums[0];
            //int largest = nums[0];

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (smallest > nums[i])
            //    {
            //        smallest = nums[i];
            //    }
            //    else if (largest < nums[i])
            //    {
            //        largest = nums[i];
            //    }
            //    else
            //    {
            //        int result = largest + smallest;
            //        Console.WriteLine(result);
            //    }
            //}
            #endregion
            #region exercise8

            //            string[] seasons = { "yaz", "yay", "payiz", "qis" };

            //            bool loop = true;
            //            while (loop)
            //            {
            //                try
            //                {
            //                    Console.WriteLine("1-4 arasi eded daxil edin: ");
            //                    int s = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine(seasons[s - 1]);
            //                }
            //                catch (Exception)
            //                {
            //                    Console.WriteLine("daxil etdiyiniz eded duzgun deyil !");
            //                }
            //            }
            #endregion
            #region exercise9

            //    String[] arr = { "nicat", "fezail", "elovset", "gulendam", "bagdagul" };
            //    printStrings(arr);
            //}
            //    static int maxLength(String[] arr)
            //    {
            //        int len = int.MinValue;
            //        int n = arr.Length;

            //        for (int i = 0; i < n; i++)
            //        {

            //            int l = arr[i].Length;

            //            if (len < l)
            //            {
            //                len = l;
            //            }
            //        }

            //        return len;
            //    }

            //    static void maxStrings(String[] arr,
            //                        int len)
            //    {
            //        int N = arr.Length;
            //        List<String> ans = new List<String>();

            //        for (int i = 0; i < N; i++)
            //        {
            //            if (len == arr[i].Length)
            //            {
            //                ans.Add(arr[i]);
            //            }
            //        }

            //        for (int i = 0; i < ans.Count; i++)
            //        {
            //            Console.Write(ans[i] + " ");
            //        }
            //    }

            //    static void printStrings(String[] arr)
            //    {

            //        int max = maxLength(arr);

            //        maxStrings(arr, max);
            //    }
            #endregion
            #region exercise10

            //int a = 1;
            //int b = 1;
            //while (b < 11)
            //{
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 2;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 3;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 4;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 5;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 6;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 7;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b < 11)
            //{
            //    a = 8;
            //    Console.WriteLine(a*b);
            //    b++;
            //}
            //b = 1;
            //while (b<11)
            //{
            //    a = 9;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            //b = 1;
            //while (b<11)
            //{
            //    a = 10;
            //    Console.WriteLine(a * b);
            //    b++;
            //}
            #endregion
        }
    }
}







