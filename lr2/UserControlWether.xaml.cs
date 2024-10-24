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
using lr2.DataModel;

namespace lr2
{
    /// <summary>
    /// Логика взаимодействия для UserControlWether.xaml
    /// </summary>
    public partial class UserControlWether : UserControl
    {
        public UserControlWether()
        {
            InitializeComponent();
        }
        public UserControlWether(Weather weather)
        {
            InitializeComponent();
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["weatherViewSource"];
            myCollectionViewSource.Source = new List<Weather>() { weather };
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
