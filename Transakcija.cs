using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public abstract class Transakcija : ITransakcija
    {
        private decimal amount;
        public decimal Amount {  get; set; }
        public abstract void Execute(Korisnik sender, Korisnik receiver, decimal amount);
        
    }
}
