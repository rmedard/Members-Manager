using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNC.Entities
{
    class Attendance
    {
        private int id;
        private Member attendee;
        private Meeting attendedMeeting;

        public Attendance() { }

        public Attendance(Member member, Meeting meeting)
        {
            this.Attendee = member;
            this.AttendedMeeting = meeting;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Member Attendee
        {
            get { return attendee; }
            set { attendee = value; }
        }

        public Meeting AttendedMeeting
        {
            get { return attendedMeeting; }
            set { attendedMeeting = value; }
        }
    }
}
