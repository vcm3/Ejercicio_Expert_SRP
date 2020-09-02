using System;
using System.Text;

namespace Library
{
    public class Pacient
    {
        public void Pacient(string name, string id, string phoneNumber, string age)
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(age))
            {
                stringBuilder.Append("Unable to schedule appointment, Age is required\n");
                isValid = false;
            }

            if (isValid)
            {
                PacientName = name;
                PhoneNumber = phoneNumber;
                Age = age;
                Id = id;
            }

        }

    }
}
