using PiedraPapelTijeraLagartoSpock.Base;
using PiedraPapelTijeraLagartoSpock2;
using PiedraPapelTijeraLagartoSpock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijeraLagartoSpock.Common
{
    public static class Controller
    {
        public static IPiedraPapelTijeraLagartoSpockService GetService()
        {
            return new PartidaService();
        }
    }
}
