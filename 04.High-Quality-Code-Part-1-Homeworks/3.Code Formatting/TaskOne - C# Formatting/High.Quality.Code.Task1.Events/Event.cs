using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High.Quality.Code.Task1.Events
{
    public class Event : IComparable
    {
        public DateTime date;
        public string title;
        public string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder();

            toStringResult.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toStringResult.Append(" | " + title);

            if (location != null && location != "")
            {
                toStringResult.Append(" | " + location);
            }

            return toStringResult.ToString();
        }
    }
}
