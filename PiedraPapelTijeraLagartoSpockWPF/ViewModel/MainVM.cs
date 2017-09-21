using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiedraPapelTijeraLagartoSpock;
using System.ComponentModel;
using PiedraPapelTijeraLagartoSpock.Base;
using PiedraPapelTijeraLagartoSpock.Common;

namespace PiedraPapelTijeraLagartoSpockWPF.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private IPiedraPapelTijeraLagartoSpockService service;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            service = Controller.GetService();

            EmpezarJuego();
        }

        private JugadasEnum? jugadaJugador;
        public JugadasEnum? JugadaJugador
        {
            get { return jugadaJugador; }
            set
            {
                jugadaJugador = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("JugadaJugador"));
            }
        }

        private JugadasEnum? jugadaPC;
        public JugadasEnum? JugadaPC
        {
            get { return jugadaPC; }
            set
            {
                jugadaPC = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("JugadaPC"));
            }
        }

        private Resultado? resultado;
        public Resultado? Resultado
        {
            get { return resultado; }
            set
            {
                resultado = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Resultado"));
            }
        }

        private bool jugando = true;
        public bool Jugando
        {
            get { return jugando; }
            set
            {
                jugando = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jugando"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NoJugando"));
            }
        }

        public bool NoJugando
        {
            get
            {
                return !Jugando;
            }
        }

        public void EmpezarJuego()
        {
            Resultado = null;
            JugadaJugador = null;
            JugadaPC = null;
            Jugando = true;
        }

        public void Jugar(JugadasEnum jugada)
        {
            JugadaJugador = jugada;
            JugadaPC = GetRandomJugada();

            Resultado = service.ResolverPartida(JugadaJugador.Value, JugadaPC.Value);

            Jugando = false;
        }

        private int i = DateTime.Now.Millisecond;
        private JugadasEnum GetRandomJugada()
        {
            return (JugadasEnum)(new Random(i++).Next(1, 6));
        }

    }
}
