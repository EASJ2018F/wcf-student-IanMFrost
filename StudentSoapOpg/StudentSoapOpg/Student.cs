using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSoapOpg
{
    public class Student
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string Room { get; set; }
        public int Grade { get; set; }
        public int PhoneNumber { get; set; }

        public Student(string name, string classname, string room, int grade, int phoneNumber)
        {
            Name = name;
            ClassName = classname;
            Room = room;
            Grade = grade;
            PhoneNumber = phoneNumber;
        }
    }
}