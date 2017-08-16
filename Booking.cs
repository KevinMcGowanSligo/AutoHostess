using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHostess
{
    class Booking
    {
        string name;
        DateTime startTime;
        DateTime endTime;
        DateTime expectedTime;
        int persons;

        
        public Booking()
        {

        }

        public Booking(string name, DateTime startTime, int persons)
        {
            this.name = name;
            this.startTime = startTime;
            this.persons = persons;
        }

        public DateTime SetExpectedTime()
        {
            if(persons<=2)
            {
                expectedTime = expectedTime.AddHours(1);
                expectedTime = expectedTime.AddMinutes(15);
            }
            else if(persons>=4)
            {
                expectedTime = expectedTime.AddHours(1);
                expectedTime = expectedTime.AddMinutes(45);
            }
            else if(persons>=6)
            {
                expectedTime = expectedTime.AddHours(2);
                expectedTime = expectedTime.AddMinutes(0);
            }
            else if(persons>=10)
            {
                expectedTime = expectedTime.AddHours(2);
                expectedTime = expectedTime.AddMinutes(30);
            }
            return expectedTime;
        }

        public DateTime SetEndTime()
        {
            endTime = startTime.AddHours(expectedTime.Hour);
            endTime = startTime.AddMinutes(expectedTime.Minute);
            
            return endTime;
        }


    }
    
}
