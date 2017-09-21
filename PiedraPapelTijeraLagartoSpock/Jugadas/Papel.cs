using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock.Jugadas
{
    public class Papel : Jugada
    {
        public override bool VenceA(Jugada oponente)
        {
            return (oponente is Piedra || oponente is Spock);
        }
    }
}
