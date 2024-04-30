using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
     public class Banka
    {
        private Dictionary<string, decimal> Users;

        public Banka()
        {
            Users = new Dictionary<string, decimal>();
        }

        public void Add (Korisnik korisnik)
        {
            Users.Add(korisnik.ID,korisnik.Balance);
        }
        public void Remove (Korisnik korisnik)
        {
            Users.Remove(korisnik.ID);
        }

        

        public void Ispis()
        {
            foreach (KeyValuePair<string,decimal> korisnik in Users)
            {
                Console.WriteLine("ID: {0} BALANCE: {1}",korisnik.Key, korisnik.Value);
            }
        }
    }
}
