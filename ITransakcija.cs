using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public interface ITransakcija
    {
        void Execute(Korisnik sender, Korisnik receiver, decimal amount);
    }
}
