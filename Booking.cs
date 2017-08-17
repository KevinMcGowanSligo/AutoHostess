using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHostess
{
    class Booking
    {
        public string name;
        public DateTime startTime;
        public DateTime endTime;
        TimeSpan expectedTime;
        int persons;

        
        public Booking()
        {

        }

        public Booking(string name, DateTime startTime, int persons)
        {
            this.name = name;
            this.startTime = startTime;
            this.persons = persons;
            SetExpectedTime();
            SetEndTime();
        }

        public TimeSpan SetExpectedTime()
        {
            //set expected seated time to a new timespan (hours, minutes, seconds)

            if(persons<=2)
            {
                expectedTime = new TimeSpan(1, 30, 0);
            }
            else if(persons<=4)
            {
                expectedTime = new TimeSpan(1, 45, 0);
            }
            else if(persons<=6)
            {
                expectedTime = new TimeSpan(2, 0, 0);
            }
            else if(persons>=10)
            {
                expectedTime = new TimeSpan(2, 30, 0);
            }
            return expectedTime;
        }

        public DateTime SetEndTime()
        {
            endTime = startTime.Add(expectedTime);

            return endTime;
        }


    }
    
}
