using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public interface IBankovniRacun
    {
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        void CheckBalance(Korisnik korisnik);

    }
}
