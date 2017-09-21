using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock.Jugadas
{
    public abstract class Jugada
    {
        public abstract bool VenceA(Jugada oponente);

        public override bool Equals(object obj)
        {
            if (obj is Jugada)
                return obj.GetType() == this.GetType();

            return base.Equals(obj);
        }

    }
}
