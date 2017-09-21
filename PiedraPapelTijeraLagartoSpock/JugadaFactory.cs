using PiedraPapelTijeraLagartoSpock.Base;
using PiedraPapelTijeraLagartoSpock.Jugadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock
{
    public class JugadaFactory
    {
        public T Lanzar<T>() where T : Jugada, new()
        {
            return new T();
        }

        public Jugada Lanzar(JugadasEnum jugada)
        {
            switch (jugada)
            {
                case JugadasEnum.Piedra:
                    return new Piedra();
                case JugadasEnum.Papel:
                    return new Papel();
                case JugadasEnum.Tijera:
                    return new Tijera();
                case JugadasEnum.Lagarto:
                    return new Lagarto();
                case JugadasEnum.Spock:
                    return new Spock();
                default:
                    throw new InvalidOperationException("Jugada no válida.");
            }
        }
    }
}
