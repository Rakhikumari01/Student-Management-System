using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Subject
    {

       public int SubjectCode;
        public String SubjectName;


        public Subject(int subjectCode, String subjectName)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
           
        }

        public void displayInfo()
        {
            Console.WriteLine($"subject code is: {SubjectCode}");
            Console.WriteLine($"subject Name is: {SubjectName}");
        }

    }

}
