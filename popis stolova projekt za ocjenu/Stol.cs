using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popis_stolova_projekt_za_ocjenu
{
    class Stol : IStol
    {
        public int ID { get; set; }
        public int BrojStola { get; set; }
        public int Kapacitet { get; set; }
        public string Status { get; set; }

        public Stol(int id, int brojStola, int kapacitet, string status)
        {
            ID = id;
            BrojStola = brojStola;
            Kapacitet = kapacitet;
            Status = status;
        }

        public void IspisDetalja()
        {
            Console.WriteLine($"ID: {ID}, Broj Stola: {BrojStola}, Kapacitet: {Kapacitet}, Status: {Status}");
        }
    }
}
