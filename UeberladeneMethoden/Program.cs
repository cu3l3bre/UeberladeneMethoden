using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberladeneMethoden
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] test = { 2.0, 8.0, 3.0, 19.0, 32.0, 12.0, 99.0, 55.0, 1.0 };
            double[] test2 = { 2.0, 8.0, 3.0, 19.0, 32.0, 12.0, 99.0, 55.0, 1.0 };  // test;

            //double[] test2 = test; // Verweis auf einen Verweis, so wüde der selbe Datensatz bearbeitet


            Console.Write("          Ungeordnet: ");
            foreach (double wert in test)
            {
                Console.Write(wert + " ");
            }
            Console.WriteLine();


            MethodenUeberladen.BubbleSort(test, false); // Aufsteigend
            MethodenUeberladen.BubbleSort(test2, true); // Absteigend


            Console.Write("Aufsteigend geordnet: ");
            foreach (double wert in test)
            {
                Console.Write(wert + " ");
            }
            Console.WriteLine();


            Console.Write(" Absteigend geordnet: ");
            foreach (double wert in test2)
            {
                Console.Write(wert + " ");
            }
            Console.WriteLine();



            int zahl = MethodenUeberladen.findeHoechsteZahl(1,23,134,5,6,7,88);
            Console.WriteLine("Groesste Zahl ist {0}", zahl);



            Console.ReadKey();
        }
    }
}
