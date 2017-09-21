using PiedraPapelTijeraLagartoSpock.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PiedraPapelTijeraLagartoSpockWPF.Helpers
{
    public class JugadaVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var jugada = (JugadasEnum?)value;
            var jugadaObjetivo = (JugadasEnum)Enum.Parse(typeof(JugadasEnum), (string)parameter);

            if (jugada == jugadaObjetivo)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
