using PiedraPapelTijeraLagartoSpock.Base;
using PiedraPapelTijeraLagartoSpockWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PiedraPapelTijeraLagartoSpockWPF
{
    /// (JugadasEnum.summary>
    /// Interaction logic for MainWindow.xaml
    /// (JugadasEnum./summary>
    public partial class MainWindow : Window
    {
        private MainVM viewModel;

        public MainWindow()
        {
            viewModel = new MainVM();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Reiniciar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.EmpezarJuego();
        }

        private void Spock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Jugar(JugadasEnum.Spock);
        }

        private void Piedra_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Jugar(JugadasEnum.Piedra);
        }

        private void Lagarto_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Jugar(JugadasEnum.Lagarto);
        }

        private void Papel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Jugar(JugadasEnum.Papel);
        }

        private void Tijera_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Jugar(JugadasEnum.Tijera);
        }
    }
}
