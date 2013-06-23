using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNC.Implementors;

namespace RNC.Entities
{
    public enum Gender
    {
        Male, Female, Unspecified
    };

    public enum Province
    {
        Bruxelles, Charleroi, Liège, Anvers, Namur, Etranger, Unspecified
    };

    public class Member
    {

        private int id;
        private string lastname;
        private string firstname;
        private Gender sex;
        private Province province;
        private string email;
        private string phone;
        private int cardnum;
        private DateTime entryDate;

        public double AttendanceRate
        {
            get { return new MemberImpl().getMemberAttendanceRate(this); }
        }

        private bool isValid;

        public Member()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public Gender Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Province City
        {
            get { return province; }
            set { province = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int Cardnum
        {
            get { return cardnum; }
            set { cardnum = value; }
        }

        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }

        public bool IsValid
        {
            get { return isValid; }
            set { isValid = value; }
        }

    }
}
