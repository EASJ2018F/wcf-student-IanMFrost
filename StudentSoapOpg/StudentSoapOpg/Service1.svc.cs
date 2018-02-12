using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentSoapOpg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       
        public void AddStudent(string name, string classname, string room, int grade, int phoneNumber)
        {
            ListOfStudents().Add(new Student(name, classname, room, grade, phoneNumber), phoneNumber);
        }

        public Dictionary<Student, int> ListOfStudents()
        {
            return new Dictionary<Student, int>();
        }
    }
}
