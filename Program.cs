using System;

namespace Zadaca1
{
    class Test
    {
        public static void Main(string[] args) 
        {
            Banka banka = new Banka();
            Korisnik korisnik1 = new Korisnik("Pero","Peric","233421", 120);
            Korisnik korisnik2 = new Korisnik("Duro", "Duric", "211521", 11220);
            Korisnik korisnik3 = new Korisnik("Ana", "Anic", "331243", 1476);

            banka.Add(korisnik1);
            banka.Add(korisnik2);
            banka.Add(korisnik3);
            banka.Ispis();

            korisnik1.CheckBalance(korisnik1);
            korisnik2.CheckBalance(korisnik2);   
            korisnik3.CheckBalance(korisnik3);

            korisnik1.Balance = 0;
            korisnik1.Withdraw(100);
            Prijenos Transakcija = new Prijenos();
            Transakcija.Execute(korisnik2, korisnik1, 350);
            korisnik1.CheckBalance(korisnik1);
            korisnik2.CheckBalance(korisnik2);

        }
    }
}
