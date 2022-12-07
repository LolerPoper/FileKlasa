using System;
using System.IO;
namespace FileKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite Vaše ime: ");
            string ime = Console.ReadLine();
            string datoteka = "ime.txt";
            // Provjeravamo postoji li datoteka ime.txt
            if (File.Exists(datoteka))
            {
                // Ako postoji kopiramo ju u backup direktorij
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                File.Copy(datoteka, "backup\\ime_"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ ".txt");
                // Brišemo tu datoteku
                File.Delete(datoteka);
            }
            // U datoteku spremamo novo ime
            File.WriteAllText(datoteka, ime);
        }
    }
}