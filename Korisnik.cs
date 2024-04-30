using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
     public class Korisnik : Osoba, IBankovniRacun
    {

        public decimal Balance { get; set; }
        public string ID { get; set; }

        public Korisnik(string name,string secondname, string id, decimal balance)
        {
            this.name = name;
            this.secondname = secondname;
            this.ID = id;
            this.Balance = balance; 
        }
        public void Withdraw(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance = Balance - amount;
            }
            Console.WriteLine("Brokie :(");
        }

        public void Deposit (decimal amount)
        {
            Balance += amount;

        }

        public void CheckBalance(Korisnik korisnik)
        {
            Console.WriteLine($" Name: {korisnik.name}\n Secondname: {korisnik.secondname} \n Balance: {Balance}  ");
        }
    }
}
