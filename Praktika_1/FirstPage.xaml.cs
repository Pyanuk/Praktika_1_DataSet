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
using Praktika_1.COFFEE_HOUSEDataSetTableAdapters;

namespace Praktika_1
{

    public partial class FirstPage : Page
    {
        NAME_COFFEETableAdapter NAME_COFFEE = new NAME_COFFEETableAdapter();
        public FirstPage()
        {
            InitializeComponent();
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();
        }
    }
}
