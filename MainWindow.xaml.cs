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

namespace AutoHostess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Table[] tables;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBookTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private Table[] CreateTables()
        {
            //create all tables array should have one less then the last prefered table.

            tables[0] = new Table(12, 2);
            tables[1] = new Table(18, 2);
            tables[2] = new Table(5, 2);
            tables[3] = new Table(26, 4);
            tables[4] = new Table(17, 4);
            tables[5] = new Table(11, 4);
            tables[6] = new Table(10, 4);
            tables[7] = new Table(4, 4);
            tables[8] = new Table(3, 4);
            tables[9] = new Table(22, 2);
            tables[10] = new Table(23, 2);
            tables[11] = new Table(24, 2);
            tables[12] = new Table(21, 4);
            tables[13] = new Table(9, 6);
            tables[14] = new Table(8, 4);
            tables[15] = new Table(15, 4);
            tables[16] = new Table(14, 4);
            tables[17] = new Table(13, 4);
            tables[18] = new Table(19, 4);
            tables[19] = new Table(20, 6);
            tables[20] = new Table(2, 6);
            tables[21] = new Table(1, 6);
            tables[22] = new Table(6, 8);
            return tables;
        }
    }


}
