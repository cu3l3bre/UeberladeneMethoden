using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberladeneMethoden
{
    public static class MethodenUeberladen
    {

        public static void BubbleSort(double[] werte)
        {
            for (int i = 0; i < werte.Length - 1; i++)
            {
                for (int j = i + 1; j < werte.Length; j++)
                {
                    if (werte[i] > werte[j])
                    {
                        double tmp = werte[i];
                        werte[i] = werte[j];
                        werte[j] = tmp;
                    }
                }
            }
        }


        public static void BubbleSort(double[] werte, bool orderDesc) // false = asecnding, true = descending 
        {
            for (int i = 0; i < werte.Length - 1; i++)
            {
                for (int j = i + 1; j < werte.Length; j++)
                {               
                    //Console.WriteLine("Aufsteigend...");
                    if ((!orderDesc && werte[i] > werte[j]) || (orderDesc && werte[i] < werte[j]))
                    {
                        double tmp = werte[i];
                        werte[i] = werte[j];
                        werte[j] = tmp;
                    }

                }
            }
        }


        // Methoden mit variabler Parameteranzahl
        public static int findeHoechsteZahl(params int[] zahlen)
        {
            int hoechsteZahl = 0;
            int summe = 0;

            if (zahlen.Length == 0)
            {
                Console.WriteLine("Es wurden keinen Zahlen uebergeben");
            }

            hoechsteZahl = zahlen.Max();

            foreach(int zahl in zahlen)
            {
                summe += zahl;
            }

            double durchschnitt = summe / (double)zahlen.Length;
            Console.WriteLine("Durschnitt: {0}", durchschnitt);


            return hoechsteZahl;
            
        }


    }
}
