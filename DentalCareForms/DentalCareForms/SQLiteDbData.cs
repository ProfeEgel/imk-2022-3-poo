using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;
using DentalCareForms;

namespace SQLiteDb
{
    public partial class SQLiteConn
    {
        internal List<Day> GetDays()
        {
            var daysList = new List<Day>();

            using (var rs = ExecuteQuery("SELECT DISTINCT a.day_id, d.name\r\nFROM appointments a\r\nINNER JOIN days d ON (a.day_id = d.id)\r\nORDER BY a.day_id"))
            {
                while (rs.NextRecord())
                {
                    daysList.Add(new Day(rs.GetInt32("day_id"), rs.GetString("name")));
                }
            }

            return daysList;
        }

        internal List<AppointmentByTime> GetAppointmentsByTime(int dayId)
        {
            string query = $"SELECT t.description AS time_description, p.last_name||', '||p.first_name AS patient_full_name\r\nFROM appointments a\r\nINNER JOIN patients p ON (a.patient_id = p.id)\r\nINNER JOIN times t ON (a.time_id = t.id)\r\nWHERE day_id = {dayId}\r\nORDER BY t.id";

            var appointments = new List<AppointmentByTime>();
            using (var rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    appointments.Add(new AppointmentByTime(rs.GetString("time_description"),
                                                           rs.GetString("patient_full_name")));
                }
            }

            return appointments;
        }

        internal List<AppointmentByPatient> GetAppointmentsByPatient()
        {
            string query = "SELECT p.last_name||', '||p.first_name AS patient_full_name,\r\n       d.name AS day_name,\r\n       t.description AS time_description\r\nFROM appointments a\r\nINNER JOIN patients p ON (a.patient_id = p.id)\r\nINNER JOIN days d ON (a.day_id = d.id)\r\nINNER JOIN times t ON (a.time_id = t.id)\r\nORDER BY patient_full_name";

            var appointments = new List<AppointmentByPatient>();
            using (var rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    appointments.Add(new AppointmentByPatient(rs.GetString("patient_full_name"),
                                                              rs.GetString("day_name"),
                                                              rs.GetString("time_description")));
                }
            }

            return appointments;
        }

        internal List<Patient> GetAvailablePatients()
        {
            string query = "SELECT id, p.first_name, p.last_name\r\nFROM patients p\r\nWHERE p.id NOT IN(SELECT patient_id FROM appointments)\r\nORDER BY last_name, first_name";

            var patients = new List<Patient>();
            using (var rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    patients.Add(new Patient(rs.GetInt32("id"),
                                             rs.GetString("first_name"),
                                             rs.GetString("last_name")));
                }
            }

            return patients;
        }

        internal List<Day> GetAvailableDays()
        {
            string query = "SELECT DISTINCT d.*\r\nFROM schedules s\r\nINNER JOIN days d ON (s.day_id = d.id) \r\nWHERE (day_id, time_id) NOT IN (SELECT day_id, time_id\r\n                                FROM appointments)";

            var days = new List<Day>();
            using (var rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    days.Add(new Day(rs.GetInt32("id"),
                                     rs.GetString("name")));
                }
            }

            return days;
        }

        internal List<Time> GetAvailableTimes(int dayId)
        {
            string query = $"SELECT t.*\r\nFROM schedules s\r\nINNER JOIN times t ON (s.time_id = t.id) \r\nWHERE (day_id, time_id) NOT IN (SELECT day_id, time_id\r\nFROM appointments)\r\nAND day_id = {dayId}\r\nORDER BY t.id";

            var times = new List<Time>();
            using (var rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    times.Add(new Time(rs.GetInt32("id"),
                                       rs.GetString("description")));
                }
            }

            return times;
        }

        internal void GenerateAppointment(int patientId, int dayId, int timeId)
        {
            string query = $"INSERT INTO appointments(patient_id, day_id, time_id) VALUES({patientId},{dayId},{timeId})";
            ExecuteNonQuery(query);
        }
    }
}
