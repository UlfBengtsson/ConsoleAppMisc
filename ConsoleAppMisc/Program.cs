using ConsoleAppMisc.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleAppMisc
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OverLoadEx();
            //CollcetionsEx();
            BadCakeMaker();
        }

        static void BadCakeMaker()
        {
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake burntCake = new Cake("strabarry", "cream", time, temp);

            try
            {
                burntCake.BakeTheCake(temp * 9, time * 5);
            }
            catch (Exception exceptionThrown)
            {
                Console.WriteLine(exceptionThrown.Message);
            }
        }

        static void OverLoadEx()
        {
            int BirthYear = 1982;
            Console.WriteLine($"Int: Person born {BirthYear} is {PersonsAge(BirthYear)} yers old this year");

            DateTime myDate = new DateTime(1982, 9, 17);
            Console.WriteLine($"Int: Person born {BirthYear} is {PersonsAge(myDate)} yers old this year");
        }

        static void CollcetionsEx()
        {
            List<double> luckyNumbers = new List<double> { 13.0, 7.1 };
            double number = 42.24;

            AddNumberToList(luckyNumbers, number);

            Console.WriteLine("number is: " + number);

            foreach (double item in luckyNumbers)
            {
                Console.WriteLine("lucky: " + item);
            }

            Console.WriteLine("add good text as number: " + AddNumberToList(luckyNumbers, "8,8"));
            Console.WriteLine("add bad text as number: " + AddNumberToList(luckyNumbers, "hello"));

            foreach (double item in luckyNumbers)
            {
                Console.WriteLine("lucky: " + item);
            }
        }

        static int PersonsAge(int BirthYear)
        {
            return DateTime.Now.Year - BirthYear;
        }

        static int PersonsAge(DateTime BirthDate)
        {

            int yearsDiff = DateTime.Now.Year - BirthDate.Year;

            if (DateTime.Now.Month <= BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
            {
                yearsDiff--;// -1 to yearsDiff
            }

            return yearsDiff;
        }

        public static bool AddNumberToList(List<double> numbersList, double toAdd)
        {
            numbersList.Add(toAdd);
            toAdd -= 12;//this only changes the copy inside this method, it will not change anything outside this method.
            return true;
        }

        public static bool AddNumberToList(List<double> numbersList, string toAdd)
        {
            double numberToAdd = 0;

            if (string.IsNullOrWhiteSpace(toAdd))
            {
                return false;
            }

            toAdd = toAdd.Replace(',', '.');
            if (double.TryParse(toAdd, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out numberToAdd))
            {
                numbersList.Add(numberToAdd);
                return true;
            }
            return false;
        }

    }
}
