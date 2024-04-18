namespace Nitrilon.Entities
{
    public class Event
    {
        #region Fields and constants
        public readonly DateTime EarliestPossibleEvent = new DateTime(2018, 1, 1);
        private int id;
        private string name;
        private DateTime date;
        private int attendees;
        private string description;
        #endregion

        #region Constructors
        public Event(int id, string name, DateTime date, int attendees, string description)
        {
            Id = id;
            Name = name;
            Date = date;
            Attendees = attendees;
            Description = description;
        }
        #endregion

        #region Properties
        public int Id
        {
            get => id;
            private set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                if(id != value)
                {
                    id = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrWhiteSpace(value);
                if(name != value)
                {
                    name = value;
                }
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, EarliestPossibleEvent);
                if(date != value)
                {
                    date = value;
                }
            }
        }

        public int Attendees
        {
            get => attendees;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, -1);
                if(attendees != value)
                {
                    attendees = value;
                }
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if(description != value)
                {
                    description = value;
                }
            }
        } 
        #endregion
    }
}