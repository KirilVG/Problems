using System;

namespace writing_numbers_as_words
{

    class Geeks
    {
        static string numberAsWord(int number)
        {
            string result="";
            string[] one_digit_numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] two_digit_nubers = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninenteen" };
            string[] numbers_devisible_by_ten = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eigthy", "ninety", "a hundred" };


            if (number < 10) result += one_digit_numbers[number];
            else if (number >= 10 && number < 20) result += two_digit_nubers[number % 10];
            else if(number>=20 && number<=100)
            {
                result += numbers_devisible_by_ten[ number / 10 - 2];
                if (number % 10 != 0) result += " " + one_digit_numbers[number % 10];
            }
            else
            {
                throw new ArgumentException("numbers above 10 are not suprted");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(numberAsWord(num));

        }
    }
}
