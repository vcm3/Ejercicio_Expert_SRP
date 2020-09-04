using System;
using System.Text;
using Doctor;
using Patient;

namespace Library
{
    public class AppointmentService
    {
        private int appointmentId;
        public static string CreateAppointment(Doctor doctor, Patient pacient, DateTime date, string appoinmentPlace)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (doctor != null && pacient != null)
            {
                isValid = false;
            }

            if (date != null)
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment date is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            if (isValid)
            {
                appointmentId = appointmentId++;
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
