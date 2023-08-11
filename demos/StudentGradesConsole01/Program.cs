using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentGradesConsole01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "John", LabGrade = 77.8m, TestGrade = 93.2m },
                new Student { Name = "Jane", LabGrade = 100.0m, TestGrade = 99.4m },
                new Student { Name = "Mark", LabGrade = 88.7m, TestGrade = 90.25m },
                new Student { Name = "Paul", LabGrade = 78.4m, TestGrade = 66.0m },
                new Student { Name = "Mary", LabGrade = 88.8m, TestGrade = 97.3m },
                new Student { Name = "Judy", LabGrade = 99.4m, TestGrade = 89.8m },
                new Student { Name = "Jill", LabGrade = 68.8m, TestGrade = 88.7m },
                new Student { Name = "Mike", LabGrade = 55.6m, TestGrade = 73.8m },
                new Student { Name = "Kent", LabGrade = 76.5m, TestGrade = 89.9m },
                new Student { Name = "Gail", LabGrade = 89.8m, TestGrade = 99.2m }
            };
        }
    }
}
