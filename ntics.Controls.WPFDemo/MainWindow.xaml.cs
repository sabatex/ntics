using ntics.Controls.WPFDemo.Models;
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

namespace ntics.Controls.WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindowModel model;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //model = new MainWindowModel();
            DataContext = MainWindowModel.TestModel;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var editItems = new Views.EditComboboxItems();
            editItems.Owner = this;
            editItems.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = MainWindowModel.TestModel;

        }
    }
}
