using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DateTimePeriodSelect.xaml
    /// </summary>
    public partial class DateTimePeriodSelect : UserControl, INotifyPropertyChanged
    {
        DateTimeExtensions.Period period;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTimeExtensions.Period Period
        {
            get=>period;
            set 
            {
                period = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Period)));
            } 
        }
        public DateTimePeriodSelect()
        {
            InitializeComponent();
        }
    }
}
