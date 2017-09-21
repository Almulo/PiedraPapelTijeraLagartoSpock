using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock.Base
{
    public interface IPiedraPapelTijeraLagartoSpockService
    {
        Resultado ResolverPartida(JugadasEnum jugada1, JugadasEnum jugada2);
    }
}
