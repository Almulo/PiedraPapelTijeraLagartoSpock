using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiedraPapelTijeraLagartoSpock;
using PiedraPapelTijeraLagartoSpock.Jugadas;
using PiedraPapelTijeraLagartoSpock.Base;

namespace PiedraPapelTijeraLagartoSpock.Test
{
    [TestClass]
    public class JugadasTest
    {
        [TestMethod]
        public void PiedraEmpate()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Piedra, JugadasEnum.Piedra);

            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void PiedraGanaTijera()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Piedra, JugadasEnum.Tijera);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void PiedraGanaLagarto()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Piedra, JugadasEnum.Lagarto);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void PiedraPierdePapel()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Piedra, JugadasEnum.Papel);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void PiedraPierdeSpock()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Piedra, JugadasEnum.Spock);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void PapelEmpate()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Papel, JugadasEnum.Papel);

            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void PapelGanaPiedra()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Papel, JugadasEnum.Piedra);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void PapelGanaSpock()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Papel, JugadasEnum.Spock);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void PapelPierdeTijera()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Papel, JugadasEnum.Tijera);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void PapelPierdeLagarto()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Papel, JugadasEnum.Lagarto);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void TijeraEmpate()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Tijera, JugadasEnum.Tijera);

            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void TijeraGanaPapel()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Tijera, JugadasEnum.Papel);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void TijeraGanaLagarto()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Tijera, JugadasEnum.Lagarto);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void TijeraPierdePiedra()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Tijera, JugadasEnum.Piedra);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void TijeraPierdeSpock()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Tijera, JugadasEnum.Spock);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void LagartoEmpate()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Lagarto, JugadasEnum.Lagarto);

            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void LagartoGanaSpock()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Lagarto, JugadasEnum.Spock);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void LagartoGanaPapel()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Lagarto, JugadasEnum.Papel);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void LagartoPierdePiedra()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Lagarto, JugadasEnum.Piedra);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void LagartoPierdeTijera()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Lagarto, JugadasEnum.Tijera);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void SpockEmpate()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Spock, JugadasEnum.Spock);

            Assert.AreEqual(Resultado.Empate, result);
        }

        [TestMethod]
        public void SpockGanaTijera()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Spock, JugadasEnum.Tijera);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void SpockGanaPiedra()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Spock, JugadasEnum.Piedra);

            Assert.AreEqual(Resultado.Victoria, result);
        }

        [TestMethod]
        public void SpockPierdePapel()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Spock, JugadasEnum.Papel);

            Assert.AreEqual(Resultado.Derrota, result);
        }

        [TestMethod]
        public void SpockPierdeLagarto()
        {
            var service = new JugadaService();
            var result = service.ResolverPartida(JugadasEnum.Spock, JugadasEnum.Lagarto);

            Assert.AreEqual(Resultado.Derrota, result);
        }
    }
}
