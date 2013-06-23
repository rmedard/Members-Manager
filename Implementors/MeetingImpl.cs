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
    class MeetingImpl
    {
        private ConnectionManager connectionManager;

        public MeetingImpl()
        {
            connectionManager = new ConnectionManager();
        }

        public Meeting createMeeting(Meeting meeting)
        {
            string query = "INSERT INTO meeting (meeting_date, meeting_venue) VALUES (@date, @venue)";
            return insertOrUpdate(query, meeting, true);
        }

        public Meeting updateMeeting(Meeting meeting)
        {
            string query = "UPDATE meeting SET meeting_date = @date, meeting_venue = @venue WHERE (meeting_id = " + meeting.Id + ")";
            return insertOrUpdate(query, meeting, false);
        }

        public bool deleteMeeting(Meeting meeting)
        {
            string query = "DELETE FROM meeting WHERE meeting_id = " + meeting.Id + "";
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows == 1 ? true : false;
                    }
                }
            }
            catch (SqlCeException)
            {
                return false;
            }
        }

        public List<Meeting> getAllMeetings()
        {
            string query = "SELECT * FROM meeting ORDER BY meeting_date DESC";
            return getMeetings(query);
        }

        public List<Meeting> getMeetingById(int id)
        {
            string query = "SELECT * FROM meeting WHERE meeting_id = " + id + " ORDER BY meeting_date DESC";
            return getMeetings(query);
        }

        public List<Meeting> getMeetingByVenue(string venue)
        {
            string query = "SELECT * FROM meeting WHERE meeting_venue = '" + venue + "' ORDER BY meeting_date DESC";
            return getMeetings(query);
        }

        private List<Meeting> getMeetings(string query)
        {

            List<Meeting> meetings = new List<Meeting>();

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
                            Meeting meeting = new Meeting();
                            meeting.Id = int.Parse(row.ItemArray[0].ToString());
                            meeting.Date = Convert.ToDateTime(row.ItemArray[1].ToString());
                            meeting.Venue = row.ItemArray[2].ToString();
                            meetings.Add(meeting);
                        }
                    }
                }
                con.Close();
            }
            return meetings;
        }

        private Meeting insertOrUpdate(string query, Meeting meeting, bool newRecord)
        {
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@date", meeting.Date);
                        command.Parameters.AddWithValue("@venue", meeting.Venue);
                        int affectedRows = command.ExecuteNonQuery();

                        if (newRecord)
                        {
                            command.CommandText = "SELECT @@IDENTITY";
                            meeting.Id = Convert.ToInt32(command.ExecuteScalar().ToString()); 
                        }
                        return affectedRows == 1 ? meeting : null;
                    }
                }
            }
            catch (SqlCeException)
            {
                return null;
            }
        }

        public List<Meeting> getMeetingsBetweenTwoDates(DateTime from, DateTime to) {
            List<Meeting> meetings = new List<Meeting>();
            foreach (Meeting meeting in this.getAllMeetings()) {
                if (DateTime.Compare(meeting.Date, from) >= 0 && DateTime.Compare(meeting.Date, to) <= 0) {
                    meetings.Add(meeting);
                }
            }
            return meetings;
        }
    }
}
