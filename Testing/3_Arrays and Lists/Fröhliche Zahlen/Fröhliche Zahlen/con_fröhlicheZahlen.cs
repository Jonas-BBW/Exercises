using System;
using System.Windows.Forms;

namespace Fröhliche_Zahlen
{
    class con_fröhlicheZahlen
    {
        public static void Main(string[] args)
        {
            string zahl = Zahlabfrage();

            while (zahl != "1" && zahl != "4")
            {
                zahl = Fröhlichkeitsprüfung(zahl);
                Console.WriteLine(zahl);
            }

            zeigeErgebnis(zahl);
        }

        internal static string Zahlabfrage()
        {
            Console.WriteLine("Fröhlichkeitsprüfung");
            Console.WriteLine("Bitte geben Sie eine Zahl ein!");
            return Console.ReadLine();
        }

        internal static string Fröhlichkeitsprüfung(string zahl)
        {
            double rechnung = 0;

            int[] zahlenIntArray = new int[zahl.Length];
            for (int i = 0; i < zahl.Length; i++)
            {
                zahlenIntArray[i] = int.Parse(zahl[i].ToString());
            }

            for (int i = 0; i <= zahlenIntArray.Length; i++)
            {
                try
                {
                    rechnung = rechnung + Math.Pow(zahlenIntArray[i], 2);
                }
                catch
                {
                    rechnung = rechnung + 0;
                }
            }
            return rechnung.ToString();
        }

        internal static void zeigeErgebnis(string zahl)
        {
            switch(zahl)
            {
                case "1": MessageBox.Show("Diese Zahl ist fröhlich.", "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                case "4": MessageBox.Show("Diese Zahl ist traurig.", "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
        }
    }
}
