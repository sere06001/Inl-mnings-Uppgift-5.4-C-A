using System;
namespace Uppgift5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in fem namn");
            string[] arrayNamn = new string[5];
            for (int i = 0; i < arrayNamn.Length; i++)
            {
                arrayNamn[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Här är namnet som kommer först i bokstavsordning:");
            Array.Sort(arrayNamn);
            Console.WriteLine(arrayNamn[0]);
            Console.ReadKey();
        }
    }
}