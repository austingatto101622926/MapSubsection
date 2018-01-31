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
using MapSubsection_Library;

namespace MapSubsection_WPF
{
    /// <summary>
    /// Interaction logic for NewPage.xaml
    /// </summary>
    public partial class NewPage : Page
    {
        public NewPage()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            App current = App.Current as App;

            current.map = new Map(int.Parse(MapSize.Text), );
            this.NavigationService.Navigate(new Uri("PageTwo.xaml", UriKind.Relative));
        }
    }
}
