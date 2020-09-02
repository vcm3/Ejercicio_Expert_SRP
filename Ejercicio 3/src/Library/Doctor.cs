using System;
using System.Text;

namespace Library
{
    public class Pacient
    {
        public void Pacient(string name, string speciallity)
        {
            Boolean isValid = true;
            
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(speciallity))
            {
                stringBuilder.Append("Unable to schedule appointment, Speciallity is required\n");
                isValid = false;
            }

            if (isValid)
            {
                DoctorName = name;
                Speciallity = speciallity;
            }

        }

    }
}
