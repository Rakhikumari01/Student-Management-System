using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Student
    {
        public String Name { get; set; }
        public  String Age { get; set; }
       
        public List<Subject> subjects { get; set; }
      
        public Student(String name,String age)
        {
            Name = name;
            Age = age;
            subjects = new List<Subject>();
      
        }  
    }


    public class RegularStudent : Student
    {

        List<int> Grades = new List<int>();
        public RegularStudent(string name, string age):  base(name, age)
        {
            Name = name;
            Age = age;
            List<Subject> subjects = new List<Subject>();
            RegularSubjects();
           
        }

        public void RegularSubjects()
        {
            
            Console.WriteLine($"the subjects of regular student are:");
            Subject firstSubject = new Subject(1, "Maths");
            Subject SecondSubject = new Subject(2, "Physics");
            Subject ThirSubject = new Subject(3, "comp.sci");
            Subject FourthSubject = new Subject(4, "AI");
            Subject FifthSubject = new Subject(5, "Data Mining");
            Subject SixthSubject = new Subject(6, "Software Testing");

            subjects.Add(firstSubject);
            subjects.Add(SecondSubject);
            subjects.Add(ThirSubject);
            subjects.Add(FourthSubject);
            subjects.Add(FifthSubject);
            subjects.Add(SixthSubject);
            Console.WriteLine();
        }

        public void DisplayRegularSubjects()
        {
            foreach (var student in subjects)
            {
                student.displayInfo();
            }
        }

        public void AddGrade()
        {
            try
            {
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"Enter grade for {Name} in {subject.SubjectName}:");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    Grades.Add(grade); // Store the grades directly in RegularStudent
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
            }
        }

        public double CalculateRegularAverageGrade()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("No grades available for calculation.");
                return 0.0;
            }

            double totalGrade = Grades.Sum()/Grades.Count;
            return totalGrade;
        }


    }

    public class HonorsStudent : Student
    {
        List<int> Grade = new List<int>();
        public HonorsStudent(string name, string age) : base(name, age)
        {
            Name = name;
            Age = age;
            List<Subject> subjects = new List<Subject>();
            HonorsSubjects();
        }

        public void HonorsSubjects()
        {
            Subject specializedSub = new Subject(101, "thermodynamics");
            Subject subject1 = new Subject(102, "physics");
            Subject subject2 = new Subject(103, "AI");

            subjects.Add(specializedSub);
            subjects.Add(subject1);
            subjects.Add(subject2);
        }


        public void addHGrade()
        {
            try
            {
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"Enter grade for {Name} in {subject.SubjectName}:");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    Grade.Add(grade);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
            }

          

        }

        public double CalculateHonorsAverageGrade()
        {
            if (subjects.Count == 0 || subjects.Any(subject => Grade.Count == 0))
            {
                Console.WriteLine("No grades available for calculation.");
                return 0.0;
            }

            double totalGrade = subjects.SelectMany(subject => Grade).Average();
            return totalGrade;
        }

        public void DisplayhonorsSubjects()
        {
            Console.WriteLine("THE SUBJECTS OF HONORS STUDENT ARE:");
            foreach (var student in subjects)
            {
                student.displayInfo();
            }

            
        }

       
    }

}


   

