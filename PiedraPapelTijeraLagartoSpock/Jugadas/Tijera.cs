using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock.Jugadas
{
    public class Tijera : Jugada
    {
        public override bool VenceA(Jugada oponente)
        {
            return (oponente is Papel || oponente is Lagarto);
        }
    }
}
