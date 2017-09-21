using PiedraPapelTijeraLagartoSpock.Jugadas;
using PiedraPapelTijeraLagartoSpock.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock
{
    public class JugadaService : IPiedraPapelTijeraLagartoSpockService
    {
        private JugadaFactory factory = new JugadaFactory();

        private Resultado Jugar(Jugada jugador, Jugada oponente)
        {
            if (jugador.Equals(oponente))
                return Resultado.Empate;

            if (jugador.VenceA(oponente))
                return Resultado.Victoria;
            else
                return Resultado.Derrota;
        }

        public Resultado ResolverPartida(JugadasEnum jugada1, JugadasEnum jugada2)
        {
            return Jugar(factory.Lanzar(jugada1), factory.Lanzar(jugada2));
        }

    }
}
