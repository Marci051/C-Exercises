using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 10, 20, 30, 40, 50 };
            int target = 30;
            int index = -1; // متغیر برای نگهداری ایندکس عنصر پیدا شده

            // حلقه برای جستجوی خطی
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    index = i; // اگر عنصر پیدا شد، ایندکس را ذخیره کن
                    break; // پایان حلقه
                }
            }

            // بررسی نتیجه جستجو
            if (index != -1)
            {
                Console.WriteLine("this " + target + " in index  " + index + "  found");
            }
            else
            {
                Console.WriteLine("this " + target + "doesnt exist");
            }
             * */

            /*
            int[] numbers = { 10, 20, 30, 40, 50 }; // آرایه مرتب
            int target = 30; // عددی که می‌خواهیم جستجو کنیم
            int left = 0; // ایندکس شروع
            int right = numbers.Length - 1; // ایندکس پایان
            int index = -1; // متغیر برای نگهداری ایندکس عنصر پیدا شده

            // حلقه برای جستجوی باینری
            while (left <= right)
            {
                int mid = left + (right - left) / 2; // محاسبه ایندکس میانه

                if (numbers[mid] == target) // اگر عنصر میانه برابر با هدف باشد
                {
                    index = mid; // ایندکس عنصر پیدا شده را ذخیره کن
                    break; // پایان جستجو
                }
                else if (numbers[mid] > target) // اگر عنصر میانه بزرگتر از هدف باشد
                {
                    right = mid - 1; // جستجو در نیمه چپ
                }
                else // اگر عنصر میانه کوچکتر از هدف باشد
                {
                    left = mid + 1; // جستجو در نیمه راست
                }
            }

            // بررسی نتیجه جستجو
            if (index != -1)
            {
                Console.WriteLine("this " + target + " in index " + index + " found");
            }
            else
            {
                Console.WriteLine("this " + target + " doesnt exist");
            }

            */



            /*
            // Daryaft do adad az karbar
            Console.Write("Adad aval ra vared konid: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adad dovom ra vared konid: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Daryaft amalgar az karbar
            Console.Write("Amalgar (+، -، *، /) ra vared konid: ");
            char operation = Console.ReadLine()[0]; // Faghat avalin karakter ra migirim

            double result; // Motaghayer baraye negahdari natije

            // Estefade az switch baraye mohasebe natije
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Natije: {0} + {1} = {2}", num1, num2, result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Natije: {0} - {1} = {2}", num1, num2, result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Natije: {0} * {1} = {2}", num1, num2, result);
                    break;

                case '/':
                    if (num2 != 0) // Barresi taqsim bar sefr
                    {
                        result = num1 / num2;
                        Console.WriteLine("Natije: {0} / {1} = {2}", num1, num2, result);
                    }
                    else
                    {
                        Console.WriteLine("Khatā: Taqsim bar sefr emkan-pazir nist.");
                    }
                    break;

                default:
                    Console.WriteLine("Amalgar namavared ast. Lotfan yeki az amalgarhāye +، -، * ya / ra vared konid.");
                    break;
            }
            */


            /*
            // ایجاد یک آرایه از اعداد صحیح با مقادیر اولیه
            int[] numbers = { 1, 2, 3, 4, 5 }; // آرایه اصلی

            Console.WriteLine("first array :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // معکوس کردن آرایه
            int length = numbers.Length;
            int[] reversedNumbers = new int[length]; // آرایه جدید برای ذخیره مقادیر معکوس شده

            for (int i = 0; i < length; i++)
            {
                reversedNumbers[i] = numbers[length - 1 - i]; // معکوس کردن
            }

            // نمایش آرایه معکوس شده
            Console.WriteLine("reversed array:");
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                Console.Write(reversedNumbers[i] + " ");
            }
            Console.WriteLine();
            */

            string[] a = new string[] { "computer" };
            Array.Reverse(a); // This will reverse the array; since there's only one element, it will remain unchanged.

            foreach (string str in a) // Iterate over each string in the array
            {
                foreach (char x in str) // Iterate over each character in the string
                {
                    Console.WriteLine(x); // Print each character
                }
            }

            Console.ReadKey();
        }
    }
}
