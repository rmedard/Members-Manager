using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNC.Entities
{
    class Meeting
    {
        private int id;
        private DateTime date;
        private string venue;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Venue
        {
            get { return venue; }
            set { venue = value; }
        }
    }
}
