using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs1
{
    class Program
    {
        static void Task1()
        {
            double payment = 0;
            double hours = 0;
            string position;
            while (true)
            {
                Console.Write("Enter position(fireman, policeman, doctor): ");
                position = Console.ReadLine();
                Console.Write("Enter hours: ");
                try
                {
                    hours = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                switch (position.ToLower())
                {
                    case "fireman":
                        payment = 12 * hours;
                        break;
                    case "policeman":
                        payment = 13 * hours;
                        break;
                    case "doctor":
                        payment = 11 * hours;
                        break;
                    default:
                        Console.WriteLine("We dont have such position. Try again.");
                        break;
                }
                if (payment > 0)
                    break;
            }
            Console.WriteLine($"{position.ToLower()}'s payment for {hours} hours is {payment}.");
        }
        static void Task2()
        {
            int a = 0, b = 0;
            while (true)
            {
                Console.Write("Enter number A: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (a <= 0)
                    Console.WriteLine("Number must be bigger then zero. Try again.");
                else
                    break;
            }
            while (true)
            {
                Console.Write("Enter number B (bigger then A): ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (b <= a)
                    Console.WriteLine($"Number must be bigger then A ({a}). Try again.");
                else
                    break;
            }
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static void Task3()
        {
            int number = 0, result = 0;
            while (true)
            {
                Console.Write("Enter number to reverse: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (number <= 0)
                    Console.WriteLine("Number must be bigger then zero. Try again.");
                else
                    break;
            }
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Reversed number is {result}.");
        }
        static void Task4()
        {
            int spaces = 0;
            int digits = 0;
            int letters = 0;
            int symbols = 0;
            char tmp;
            Console.WriteLine("Enter some text. Enter '.' to exit.");
            while ((tmp = Convert.ToChar(Console.Read())) != '.')
            {
                if (char.IsWhiteSpace(tmp))
                    spaces++;
                else
                {
                    if (char.IsLetter(tmp))
                        letters++;
                    else if (char.IsDigit(tmp))
                        digits++;
                    symbols++;
                }
            }
            Console.WriteLine($"User input has {symbols} symbols ({letters} letters, {digits} digits) and {spaces} spaces.");
        }
        static void Task5()
        {
            char tmp;
            Console.WriteLine("Enter some text. Enter '.' to exit.");
            while ((tmp = Convert.ToChar(Console.Read())) != '.')
            {
                if (char.IsUpper(tmp))
                    Console.Write(char.ToLower(tmp));
                else
                    Console.Write(char.ToUpper(tmp));
            }
        }
        
        // Task 6
        static int[] ConcatinateArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);
            return result;
        }
        static int[] GetUniqueElements(int[] arr1, int[] arr2)
        {
            int[] result = new int[] { arr1[0] };
            foreach (int el in arr1)
            {
                if (Array.IndexOf(result, el) < 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = el;
                }
            }
            foreach (int el in arr2)
            {
                if (Array.IndexOf(result, el) < 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = el;
                }
            }
            return result;
        }
        static int[] GetRealyUniqueElements(int[] arr1, int[] arr2)
        {
            int[] result = new int[1];
            for (int i = 0, j = 0; i < arr1.Length; i++)
            {
                if (Array.IndexOf(arr2, arr1[i]) < 0)
                {
                    Array.Resize(ref result, ++j);
                    result[result.Length - 1] = arr1[i];
                }
            }
            return result;
        }
        static void ShowArr(int[] arr)
        {
            foreach (int el in arr)
                Console.Write($"{el, 5} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 ===============");
            Task1();
            Console.WriteLine("Task 2 ===============");
            Task2();
            Console.WriteLine("Task 3 ===============");
            Task3();
            Console.WriteLine("Task 4 ===============");
            Task4();
            Console.WriteLine("Task 5 ===============");
            Task5();
            Console.WriteLine("Task 6 ===============");
            int[] arr1 = new int[] { 1, 3, 4, 5, 7 };
            int[] arr2 = new int[] { 2, 3, 6, 5, 8 };
            Console.Write("Arr1: ");
            ShowArr(arr1);
            Console.Write("Arr2: ");
            ShowArr(arr2);
            Console.Write("ConcatinateArrays result: ");
            ShowArr(ConcatinateArrays(arr1, arr2));
            Console.Write("GetUniqueElements result: ");
            ShowArr(GetUniqueElements(arr1, arr2));
            Console.Write("GetRealyUniqueElements result: ");
            ShowArr(GetRealyUniqueElements(arr1, arr2));

            //Console.ReadKey();
        }
    }
}
