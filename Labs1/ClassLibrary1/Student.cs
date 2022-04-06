﻿namespace ClassLibrary1
{
    public class Student
    {

        //FIELDS
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //PROPERTIES
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public float Gpa { get { return _gpa; } set { _gpa = value; } }

        //CONSTRUCTORS
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }
        public Student() { }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Last Name: {LastName}\nFirst Name: {FirstName}\n" +
                $"Id: {Id}\nGPA: {Gpa:n2}\n");
        }



    }
}