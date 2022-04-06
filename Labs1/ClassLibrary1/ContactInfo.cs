using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ContactInfo
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _phoneNumber;
        private string _email;

        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public ContactInfo(string streetAddress, string city, string state, string zipCode, string phoneNumber, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public ContactInfo() { }

        public override string ToString()
        {
            return string.Format($"***Contact Info***\nAddress: {StreetAddress}\n{City}\t{State}\t{ZipCode}\n" +
                $"Phone Number: {PhoneNumber}\nEmail: {Email}\n");
        }
    }
}
