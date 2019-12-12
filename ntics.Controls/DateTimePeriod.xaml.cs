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

namespace ntics.Controls
{
    /// <summary>
    /// Interaction logic for PeriodWPF.xaml
    /// </summary>
    public partial class DateTimePeriod : UserControl
    {
        public DateTimePeriod()
        {
            InitializeComponent();
        }
        static DateTimePeriod()
        {
            DataTimePeriodProperty = DependencyProperty.Register(nameof(Period), typeof(ntics.DateTimeExtensions.DateTimePeriod), typeof(DateTimePeriod), new FrameworkPropertyMetadata(new ntics.DateTimeExtensions.DateTimePeriod(), new PropertyChangedCallback(OnPeriodChanged)));
        }

        private static void OnPeriodChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTimePeriod period = (DateTimePeriod)d;
            var newPeriod = (ntics.DateTimeExtensions.DateTimePeriod)e.NewValue;
        }

        public readonly static DependencyProperty DataTimePeriodProperty;

        public ntics.DateTimeExtensions.DateTimePeriod Period
        {
            get => (ntics.DateTimeExtensions.DateTimePeriod)GetValue(DataTimePeriodProperty);
            set => SetValue(DataTimePeriodProperty, value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
