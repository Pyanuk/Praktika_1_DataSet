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
 
    public partial class FourPage : Page
    {
        CUSTOMER_ORDERTableAdapter CUSTOMER_ORDER = new CUSTOMER_ORDERTableAdapter();
        public FourPage()
        {
            InitializeComponent();
            CUSTOMER_ORDERDataGrid.ItemsSource = CUSTOMER_ORDER.GetData();
        }
    }
}
