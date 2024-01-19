using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of regular student
            RegularStudent rs = new RegularStudent("akhil","21");
           
            rs.DisplayRegularSubjects();
            Console.WriteLine();
            rs.AddGrade();
            Console.WriteLine(); 
            double regularAverageGrade = rs.CalculateRegularAverageGrade();
            Console.WriteLine();
            Console.WriteLine($"{rs.Name} average grade: {regularAverageGrade}");

            //creating object of honor student
            HonorsStudent h = new HonorsStudent("abhishek", "25");
            Console.WriteLine();
            h.DisplayhonorsSubjects();
            Console.WriteLine();
            h.addHGrade();
            double honorsaverageGrade = h.CalculateHonorsAverageGrade();
            Console.WriteLine();
            Console.WriteLine($"{h.Name} average grade: {honorsaverageGrade}");

        }
    }
}
