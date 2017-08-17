using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHostess
{
    class Table
    {
        public int tableNumber=0;
        int seats;
        Booking[] bookings;

        public Table(int TableNumber, int Seats)
        {
            tableNumber = TableNumber;
            seats = Seats;
        }
    }
}
