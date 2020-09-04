using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public void Doctor(string name, string speciallity)
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
                this.DoctorName = name;
                this.Speciallity = speciallity;
            }

        }

    }
}
