using System;
using System.Collections.Generic;

namespace ConsoleAppMisc
{
    class Program
    {
        static void Main(string[] args)
        {
            int BirthYear = 1982;
            Console.WriteLine($"Int: Person born {BirthYear} is {PersonsAge(BirthYear)} yers old this year");

            DateTime myDate = new DateTime(1982, 9, 17);
            Console.WriteLine($"Int: Person born {BirthYear} is {PersonsAge(myDate)} yers old this year");
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

        static bool AddNumberToList(List<double> numbersList, double toAdd)
        {
            numbersList.Add(toAdd);
            return true;
        }

        static bool AddNumberToList(List<double> numbersList, string toAdd)
        {
            double numberToAdd = 0;

            if (double.TryParse(toAdd, out numberToAdd))
            {
                numbersList.Add(numberToAdd);
                return true;
            }
            return false;
        }
    }
}
