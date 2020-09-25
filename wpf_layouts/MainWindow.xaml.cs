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

namespace wpf_layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Dock.Click += Dock_Click;
            Splitted.Click += Splitted_Click;
            StackPanel.Click += StackPanel_Click;
            Grid.Click += Grid_Click;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Grid g = new Grid();
            g.Show();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Stack s = new Stack();
            s.Show();
        }

        private void Splitted_Click(object sender, RoutedEventArgs e)
        {
            Splitted s = new Splitted();
            s.Show();
        }

        private void Dock_Click(object sender, RoutedEventArgs e)
        {
            Dock d = new Dock();
            d.Show();
        }
    }
}
