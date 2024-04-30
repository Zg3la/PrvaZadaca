using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public class Prijenos : Transakcija
    {
        public override void Execute(Korisnik sender, Korisnik receiver,decimal amount)
        {
            if(sender.Balance>= amount)
            {
                sender.Balance -= amount;
                receiver.Balance += amount;
            }
        }
    }
}
