using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DentalCare
{
    internal class Agenda
    {
        private List<Day> days;
        private List<Time> times;
        private List<Schedule> schedules;
        private List<Patient> patients;
        private List<Appointment> appointments;
        
        public Agenda()
        {
            days = EasyFile<Day>.LoadDataFromFile("days.txt",
                tokens => new Day(Convert.ToInt32(tokens[0]),
                                  tokens[1]));

            times = EasyFile<Time>.LoadDataFromFile("time.txt",
                tokens => new Time(Convert.ToInt32(tokens[0]),
                                   tokens[1]));

            schedules = EasyFile<Schedule>.LoadDataFromFile("schedule.txt",
                tokens => new Schedule(Convert.ToInt32(tokens[0]),
                                       Convert.ToInt32(tokens[1])));

            patients = EasyFile<Patient>.LoadDataFromFile("patients.txt",
                tokens => new Patient(Convert.ToInt32(tokens[0]),
                                      tokens[1],
                                      tokens[2]));

            appointments = EasyFile<Appointment>.LoadDataFromFile("appointments.txt",
                tokens => new Appointment(Convert.ToInt32(tokens[0]),
                                          Convert.ToInt32(tokens[1]),
                                          Convert.ToInt32(tokens[2])));
        }

        public List<AppointmentWithInfo> GetCitasPorPaciente()
        {
            List<AppointmentWithInfo> result = new List<AppointmentWithInfo>();

            appointments.ForEach(a =>
                result.Add(new AppointmentWithInfo(
                    patients.Find(p => p.Id == a.PatientId),
                    days.Find(d => d.Id == a.DayId),
                    times.Find(t => t.Id == a.TimeId))));

            result.Sort((x, y) => x.Patient.FullName.CompareTo(y.Patient.FullName));
            //result.Sort((x, y) => x.Day.Id.CompareTo(y.Day.Id));

            return result;
        }

        public List<Day> GetDays() => new List<Day>(days);

        public List<AppointmentWithInfo> GetCitasPorDia(Day day)
        {
            List<AppointmentWithInfo> result = new List<AppointmentWithInfo>();

            appointments
                .FindAll(a => a.DayId == day.Id)
                .ForEach(a =>
                    result.Add(new AppointmentWithInfo(
                        patients.Find(p => p.Id == a.PatientId),
                        days.Find(d => d.Id == a.DayId),
                        times.Find(t => t.Id == a.TimeId))));

            result.Sort((x, y) => x.Time.Id.CompareTo(y.Time.Id));

            return result;
        }

        public bool ValidatePaciente(int patientId) =>
            patients.Exists(p => p.Id == patientId);

        public bool ValidateCitaPaciente(int patientId) =>
            appointments.Exists(a => a.PatientId == patientId);

        public void DeleteCitaPendiente(int patientId)
        {
            // Borrar cita de la lista appointments
            // Actualizar archivo
        }
    }
}
