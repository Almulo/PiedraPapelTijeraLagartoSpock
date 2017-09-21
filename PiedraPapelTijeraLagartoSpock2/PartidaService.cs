using PiedraPapelTijeraLagartoSpock.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock2
{
    public class PartidaService : IPiedraPapelTijeraLagartoSpockService
    {
        private static Dictionary<JugadasEnum, Dictionary<JugadasEnum, Resultado>> combinaciones = new Dictionary<JugadasEnum, Dictionary<JugadasEnum, Resultado>>()
        {
            {
                JugadasEnum.Piedra, new Dictionary<JugadasEnum, Resultado>()
                {
                    { JugadasEnum.Piedra, Resultado.Empate },
                    { JugadasEnum.Papel, Resultado.Derrota },
                    { JugadasEnum.Tijera, Resultado.Victoria },
                    { JugadasEnum.Lagarto, Resultado.Victoria },
                    { JugadasEnum.Spock, Resultado.Derrota }
                }
            },
            {
                JugadasEnum.Papel, new Dictionary<JugadasEnum, Resultado>()
                {
                    { JugadasEnum.Piedra, Resultado.Victoria },
                    { JugadasEnum.Papel, Resultado.Empate },
                    { JugadasEnum.Tijera, Resultado.Derrota },
                    { JugadasEnum.Lagarto, Resultado.Derrota },
                    { JugadasEnum.Spock, Resultado.Victoria }
                }
            },
            {
                JugadasEnum.Tijera, new Dictionary<JugadasEnum, Resultado>()
                {
                    { JugadasEnum.Piedra, Resultado.Derrota },
                    { JugadasEnum.Papel, Resultado.Victoria },
                    { JugadasEnum.Tijera, Resultado.Empate },
                    { JugadasEnum.Lagarto, Resultado.Victoria },
                    { JugadasEnum.Spock, Resultado.Derrota }
                }
            },
            {
                JugadasEnum.Lagarto, new Dictionary<JugadasEnum, Resultado>()
                {
                    { JugadasEnum.Piedra, Resultado.Derrota },
                    { JugadasEnum.Papel, Resultado.Victoria },
                    { JugadasEnum.Tijera, Resultado.Derrota },
                    { JugadasEnum.Lagarto, Resultado.Empate },
                    { JugadasEnum.Spock, Resultado.Victoria }
                }
            },
            {
                JugadasEnum.Spock, new Dictionary<JugadasEnum, Resultado>()
                {
                    { JugadasEnum.Piedra, Resultado.Victoria },
                    { JugadasEnum.Papel, Resultado.Derrota },
                    { JugadasEnum.Tijera, Resultado.Victoria },
                    { JugadasEnum.Lagarto, Resultado.Derrota },
                    { JugadasEnum.Spock, Resultado.Empate }
                }
            }
        };

        public Resultado Resolver(JugadasEnum jugador, JugadasEnum oponente)
        {
            return combinaciones[jugador][oponente];
        }

        public Resultado ResolverPartida(JugadasEnum jugada1, JugadasEnum jugada2)
        {
            return Resolver(jugada1, jugada2);
        }
    }
}
