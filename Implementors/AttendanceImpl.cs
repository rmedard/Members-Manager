using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNC.Tools;
using RNC.Entities;

namespace RNC.Implementors
{
    class AttendanceImpl
    {
        private ConnectionManager connectionManager;

        public AttendanceImpl()
        {
            connectionManager = new ConnectionManager();
        }

        public Attendance createAttendance(Attendance attendance)
        {
            string query = "INSERT INTO attendance (member_id, meeting_id) VALUES (@member_id, @meeting_id)";
            return insertOrUpdate(query, attendance);
        }

        public Attendance updateAttendance(Attendance attendance)
        {
            string query = "UPDATE attendance SET member_id = @member_id, meeting_id = @meeting_id WHERE (attendance_id = " + attendance.Id + ")";
            return insertOrUpdate(query, attendance);
        }

        public bool deleteAttendance(Attendance attendance)
        {
            string query = "DELETE FROM attendance WHERE attendance_id = " + attendance.Id + "";
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        int affectedRows = command.ExecuteNonQuery();
                        con.Close(); //This is not needed...When "Using" is used, the resources are disposed automatically. 
                        return affectedRows == 1 ? true : false;
                    }
                }
            }
            catch (SqlCeException)
            {
                return false;
            }
        }

        public List<Attendance> getAllAttendances()
        {
            string query = "SELECT * FROM attendance";
            return getAttendances(query);
        }

        public List<Attendance> getAttendanceById(int id)
        {
            string query = "SELECT * FROM attendance WHERE attendance_id = " + id + "";
            return getAttendances(query);
        }

        public List<Attendance> getAttendanceByMemberId(int id)
        {
            string query = "SELECT * FROM attendance WHERE member_id = " + id + "";
            return getAttendances(query);
        }

        public List<Attendance> getAttendanceByMeetingId(int id)
        {
            string query = "SELECT * FROM attendance WHERE meeting_id = " + id + "";
            return getAttendances(query);
        }

        private List<Attendance> getAttendances(string query)
        {
            List<Attendance> attendances = new List<Attendance>();

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
                            Attendance attendance = new Attendance();
                            attendance.Id = int.Parse(row.ItemArray[0].ToString());
                            attendance.Attendee = new MemberImpl().getMemberById(int.Parse(row.ItemArray[1].ToString()))[0];
                            attendance.AttendedMeeting = new MeetingImpl().getMeetingById(int.Parse(row.ItemArray[2].ToString()))[0];
                            attendances.Add(attendance);
                        }
                    }
                }
                con.Close();
            }
            return attendances;
        }

        private Attendance insertOrUpdate(string query, Attendance attendance)
        {
            try
            {
                using (SqlCeConnection con = connectionManager.getConnection())
                {
                    con.Open();
                    using (SqlCeCommand command = new SqlCeCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@member_id", attendance.Attendee.Id);
                        command.Parameters.AddWithValue("@meeting_id", attendance.AttendedMeeting.Id);
                        int affectedRows = command.ExecuteNonQuery();
                        
                        command.CommandText = "SELECT @@IDENTITY";
                        //command.ExecuteNonQuery();
                        
                        attendance.Id = Convert.ToInt32(command.ExecuteScalar().ToString());
                        con.Close();
                        return affectedRows == 1 ? attendance : null;
                    }
                }
            }
            catch (SqlCeException ex)
            {
                Console.WriteLine("Byapfuye muri attendance " + ex.Message);
                return null;
            }
        }
    }
}
