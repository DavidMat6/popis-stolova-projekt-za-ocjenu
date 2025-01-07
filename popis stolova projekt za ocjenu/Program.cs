using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popis_stolova_projekt_za_ocjenu
{

    class Program
    {
        static List<Stol> stolovi = new List<Stol>();
        static int trenutniID = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Upravljanje Stolovima ===");
                Console.WriteLine("1. Dodaj stol");
                Console.WriteLine("2. Obrisi stol");
                Console.WriteLine("3. Ispis svih stolova");
                Console.WriteLine("4. Izlaz");
                Console.Write("Izaberite opciju: ");
                string izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        DodajStol();
                        break;
                    case "2":
                        ObrisiStol();
                        break;
                    case "3":
                        IspisSvihStolova();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Neispravan unos. Pokušajte ponovo.");
                        break;
                }
            }
        }

        static void DodajStol()
        {
            Console.Write("Unesite broj stola: ");
            int brojStola = int.Parse(Console.ReadLine());

            Console.Write("Unesite kapacitet stola: ");
            int kapacitet = int.Parse(Console.ReadLine());

            Console.Write("Unesite status stola (Slobodan/Zauzet): ");
            string status = Console.ReadLine();

            Stol noviStol = new Stol(trenutniID++, brojStola, kapacitet, status);
            stolovi.Add(noviStol);

            Console.WriteLine("Stol je uspješno dodan!");
        }

        static void ObrisiStol()
        {
            Console.Write("Unesite ID stola za brisanje: ");
            int id = int.Parse(Console.ReadLine());

            Stol stolZaBrisanje = stolovi.Find(s => s.ID == id);
            if (stolZaBrisanje != null)
            {
                stolovi.Remove(stolZaBrisanje);
                Console.WriteLine("Stol je uspješno obrisan!");
            }
            else
            {
                Console.WriteLine("Stol s navedenim ID-jem nije pronađen.");
            }
        }

        static void IspisSvihStolova()
        {
            if (stolovi.Count == 0)
            {
                Console.WriteLine("Nema stolova za prikaz.");
            }
            else
            {
                Console.WriteLine("\nPopis svih stolova:");
                foreach (var stol in stolovi)
                {
                    stol.IspisDetalja();
                }
            }
        }
    }
}
