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

namespace Project_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
            this.DataContext = model;
        }

        private void AddButt_Click(object sender, RoutedEventArgs e)
        {
            model.Op = Model.CurrentOp.ADD;
        }

        private void MinButt_Click(object sender, RoutedEventArgs e)
        {
            model.Op = Model.CurrentOp.SUB;
        }

        private void MultButt_Click(object sender, RoutedEventArgs e)
        {
            model.Op = Model.CurrentOp.MULT;
        }

        private void DivButt_Click(object sender, RoutedEventArgs e)
        {
            model.Op = Model.CurrentOp.DIV;
        }

        private void EqualsButt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
