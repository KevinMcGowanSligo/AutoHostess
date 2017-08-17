using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHostess
{
    public class Table
    {
        public int tableNumber=0;
        public int seats;
        public List<Booking> bookings = new List<Booking>();

        public Table()
        {

        }

        public Table(int TableNumber, int Seats)
        {
            tableNumber = TableNumber;
            seats = Seats;
        }

        public Booking AddBooking(Booking booking)
        {

            return booking;
        }
    }
}
