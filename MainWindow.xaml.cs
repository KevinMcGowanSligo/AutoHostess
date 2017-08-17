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
        int hour;
        int minutes;
        DateTime startTime;
        int persons;
        string name;
        Booking booking;

        List<Booking> allBookings = new List<Booking>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBookTable_Click(object sender, RoutedEventArgs e)
        {
            //have to add 24hr for now
            hour = Convert.ToInt16(tbHours.Text);
            minutes = Convert.ToInt16(tbMinutes.Text);
            name = tbName.Text;
            persons = Convert.ToInt16(tbNumberPersons.Text);
            TimeSpan ts = new TimeSpan(hour, minutes, 0);
            startTime = startTime.Date + ts;
            booking = new Booking(name, startTime, persons);
            allBookings.Add(booking);

            //add item to listbox displaying just time in 24hr format using .ToString("H:mm")
            lbDisplay.Items.Add(startTime.ToString("H:mm"));

        }

        private Table[] CreateTables()
        {
            //create all tables array should have one less then the last prefered table.
            //this should eventually be a database of tables that we can can work with easier

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

        private void btnShowBookings_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < allBookings.Count; i++)
            {
                lbDisplay.Items.Add(allBookings[i].name+ " Time:" + allBookings[i].startTime.ToString("H:mm") + " " + allBookings[i].endTime.ToString("H:mm"));                
            }
        }
    }


}
