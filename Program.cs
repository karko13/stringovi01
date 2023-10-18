using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KlasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String tekst = "Danas radimo sa klasama string ";
            //ispis stringa
            Console.WriteLine(tekst);
            //broj znakova u stringu 
            Console.WriteLine(" Broj znakova: " + tekst.Length);
            //ispis velikim slovima 
            Console.WriteLine(" Velika slova " + tekst.ToUpper());
            //ispis malih slova
            Console.WriteLine(" Velika slova " + tekst.ToLower());
            //substring metoda
            Console.WriteLine(" \n -- Substring Metoda -- ");
            Console.WriteLine(tekst.Substring(0, 5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 14));
            //zamjena znakova 
            Console.WriteLine(tekst.Replace("Danas", "Sutra"));
            //Razdvajanje stringova
            Console.WriteLine("\n -- Razdvajanje stringova --");
            string[] rijeci = tekst.Split(' ');
            for(int i = 0; i < rijeci.Length;i++) 
            {
                Console.WriteLine(rijeci[i]);
            }

            foreach (string rijec in rijeci)
            {
                Console.WriteLine(rijec);
            }
            //Umetanje znakova u sring 
            Console.WriteLine("\n -- Umetanje -- ");
            Console.WriteLine(tekst.IndexOf("radimo"));
            Console.WriteLine(tekst.Insert(tekst.IndexOf(" radimo "), " intezivno"));

            Console.ReadKey();
        }
    }
}
