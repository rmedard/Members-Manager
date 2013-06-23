using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNC.Entities;
using RNC.Tools;

namespace RNC.Implementors
{
    class MemberImpl
    {
        private ConnectionManager connectionManager = new ConnectionManager();
        private Converter converter = new Converter();

        public Member addMember(Member member)
        {
            string query = "INSERT INTO members (lastname, firstname, sex, city, email, phone, cardnum, entryDate)" +
                                "VALUES (@lastname, @firstname, @sex, @city, @email, @phone, @cardnum, @entryDate)";
            return this.insertOrUpdate(query, member);
        }

        public Member updateMember(Member member)
        {
            string query = "UPDATE members SET lastname = @lastname, firstname = @firstname, sex = @sex, " +
                           "city = @city, email = @email, phone = @phone, cardnum = @cardnum, entryDate = @entryDate " +
                           "WHERE (id = " + member.Id + ")";
            return this.insertOrUpdate(query, member);
        }

        public bool deleteMember(int memberId)
        {
            string query = "DELETE FROM members WHERE id = " + memberId + "";
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        int affectedrows = command.ExecuteNonQuery();
                        con.Close();
                        return affectedrows == 1 ? true : false;
                    }
                }
            }
            catch (SqlCeException)
            {
                return false;
            }
        }

        public List<Member> getMemberById(int memberId)
        {
            string query = "SELECT * FROM members WHERE id = " + memberId + "";
            return this.getMembers(query);
        }

        public List<Member> getMemberByCardnum(int cardnum)
        {
            string query = "SELECT * FROM members WHERE cardnum = " + cardnum + "";
            return this.getMembers(query);
        }

        public List<Member> getMemberByCardnum_Like(int cardnum)
        {
            string query = "SELECT * FROM members WHERE cardnum LIKE '%" + cardnum + "%'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByFirstOrLastName_Like(string name)
        {
            string query = "SELECT * FROM members WHERE lastname LIKE '%" + name + "%' OR firstname LIKE '%" + name + "%'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByFirstOrLastname(string name)
        {
            string query = "SELECT * FROM members WHERE lastname = '" + name + "' OR firstname = '" + name + "'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByFirstnameAndLastname(string firstname, string lastname)
        {
            string query = "SELECT * FROM members WHERE lastname = '" + lastname + "' AND firstname = '" + firstname + "'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByPhone(string phone)
        {
            string query = "SELECT * FROM members WHERE city = '" + phone.ToString() + "'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByPhone_Like(string phone)
        {
            string query = "SELECT * FROM members WHERE phone LIKE '%" + phone.ToString() + "%'";
            return this.getMembers(query);
        }

        public List<Member> getAllMembers()
        {
            string query = "SELECT * FROM members";
            return this.getMembers(query);
        }

        public List<Member> getMembersBySex(Gender sex)
        {
            string query = "SELECT * FROM members WHERE sex = '" + this.converter.sexToBit(sex).ToString() + "'";
            return this.getMembers(query);
        }

        public List<Member> getMembersByProvince(Province province)
        {
            string query = "SELECT * FROM members WHERE city = '" + province.ToString() + "'";
            return this.getMembers(query);
        }

        public List<Member> getMembersBySexAndProvince(Gender sex, Province province)
        {
            List<Member> membersBySex = this.getMembersBySex(sex);
            List<Member> membersBySexAndProvince = new List<Member>();
            foreach (Member member in membersBySex)
            {
                if (member.City == province)
                {
                    membersBySexAndProvince.Add(member);
                }
            }
            return membersBySexAndProvince;
        }

        public List<Member> getmembersByNamesAndEmail_like(string token)
        {
            List<Member> members = new List<Member>();
            string query = "SELECT * FROM members WHERE email LIKE '%" + token + "%'";
            members.AddRange(getMembers(query));
            members.AddRange(getMembersByFirstOrLastName_Like(token));
            return members;
        }

        public List<Member> getMembersAccordingToDate(DateTime date, bool later)
        {
            if (later)
                return getMembers("SELECT * FROM members WHERE entryDate > '" + date + "'");
            return getMembers("SELECT * FROM members WHERE entryDate < '" + date + "'");
        }

        private List<Member> getMembers(string query)
        {
            List<Member> members = new List<Member>();

            using (SqlCeConnection con = connectionManager.getConnection())
            {
                con.Open();
                using (SqlCeCommand command = new SqlCeCommand(query, con))
                {
                    SqlCeDataAdapter adapter = new SqlCeDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            Member member = new Member();
                            member.Id = int.Parse(row.ItemArray[0].ToString());
                            member.Lastname = row.ItemArray[1].ToString();
                            member.Firstname = row.ItemArray[2].ToString();
                            member.Sex = this.converter.stringToGender(row.ItemArray[3].ToString());
                            member.City = this.converter.stringToCity(row.ItemArray[4].ToString());
                            member.Email = row.ItemArray[5].ToString();
                            member.Phone = row.ItemArray[6].ToString();
                            member.Cardnum = int.Parse(row.ItemArray[7].ToString());
                            member.EntryDate = Convert.ToDateTime(row.ItemArray[8].ToString());
                            members.Add(member);
                        }
                    }
                }
                con.Close();
            }
            return members;
        }

        private Member insertOrUpdate(string query, Member member)
        {
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@lastname", member.Lastname);
                        command.Parameters.AddWithValue("@firstname", member.Firstname);
                        command.Parameters.AddWithValue("@sex", this.converter.sexToBit(member.Sex));
                        command.Parameters.AddWithValue("@city", member.City.ToString());
                        command.Parameters.AddWithValue("@email", member.Email);
                        command.Parameters.AddWithValue("@phone", member.Phone);
                        command.Parameters.AddWithValue("@cardnum", member.Cardnum);
                        command.Parameters.AddWithValue("@entryDate", member.EntryDate);
                        int affectedRows = command.ExecuteNonQuery();
                        con.Close();
                        return affectedRows == 1 ? member : null;
                    }

                }
            }
            catch (SqlCeException ex)
            {
                Console.WriteLine("Byapfuye " + ex.Message);
                return null;
            }
        }

        public List<Member> sortMembersById(List<Member> members)
        {
            List<Member> sortedList = new List<Member>();
            Member[] membersArray = members.ToArray();
            Array.Sort(membersArray, delegate(Member member1, Member member2)
            {
                return member1.Id.CompareTo(member2.Id);
            });
            foreach (Member member in membersArray)
            {
                sortedList.Add(member);
            }
            return sortedList;
        }

        public double getMemberAttendanceRate(Member member)
        {
            MeetingImpl meetingImpl = new MeetingImpl();
            int supposedMeetingsCount = 0;
            int attendedMeetingsCount = 0;
            foreach (Meeting meeting in meetingImpl.getAllMeetings())
            {
                if (DateTime.Compare(meeting.Date, member.EntryDate) >= 0)
                {
                    supposedMeetingsCount++;
                    if (didMemberAttendSingleMeeting(meeting, member))
                    {
                        attendedMeetingsCount++;
                    }
                }
            }
            return Math.Round(Convert.ToDouble(attendedMeetingsCount / supposedMeetingsCount * 100), 2, MidpointRounding.AwayFromZero);
        }

        public bool didMemberAttendSingleMeeting(Meeting meeting, Member member)
        {
            string query = "SELECT COUNT(*) FROM attendance WHERE member_id = " + member.Id + " AND meeting_id = " + meeting.Id + "";
            int returnCount = 0;
            using (SqlCeConnection con = this.connectionManager.getConnection())
            {
                con.Open();
                using (SqlCeCommand command = new SqlCeCommand(query, con))
                {
                    command.CommandType = CommandType.Text;
                    returnCount = (Int32)command.ExecuteScalar();
                }
            }
            return returnCount > 0 ? true : false;
        }

        public bool didMemberAttendMultiMeetings(List<Meeting> meetings, Member member)
        {
            foreach (Meeting meeting in meetings)
            {
                if (!didMemberAttendSingleMeeting(meeting, member))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
