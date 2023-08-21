using Microsoft.Win32;
using StudentGradeLibrary2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesConsole02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read list of students from the
            //Text file names grades.txt
            List<Student> students = ReadStudentFromFile(
                                "C:\\Users\\jemel\\OneDrive\\Documents\\GitHub\\AWD1100-Summer2023-mayaRanken\\demos\\grades.txt");

            bool runAgain = true;
            
            while (runAgain)
            {
                Console.Clear();

                //Display the 10 students in the grades.txt file
                Console.WriteLine("here are the 10 students");

                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Lab Grade: {student.LabGrade}, Test Grade: {student.TestGrade}");
                }

                Console.WriteLine("\n\n");

                //Search for a student by name
                Console.Write("Enter student name to search for: ");
                string searchName = Console.ReadLine();

                Student foundStudent = SearchForStudent(students, searchName);

                if (foundStudent != null)
                {
                    decimal overallGrade = CalculateOverallGrade(foundStudent);
                    Console.WriteLine($"Found student: {foundStudent.Name}");
                    Console.WriteLine($"Lab Grade: {foundStudent.LabGrade}");
                    Console.WriteLine($"Test Grade: {foundStudent.TestGrade}");
                    Console.WriteLine($"Overall Grade {overallGrade:n2}");
                }
                else
                {
                    Console.WriteLine($"Student {searchName} Not Found");
                }
                Console.WriteLine("\n");
                runAgain = Again();
                
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        static List<Student> ReadStudentFromFile(string fileName)
        {
            List<Student> students = new List<Student>();
            
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Split the line into 3 fields
                        //Data[0] will hold the name
                        //Data[1] will hold the lab grade
                        //Data[2] will hold the test grade
                        string[] data = line.Split(',');

                        if ((data.Length == 3)
                        && (decimal.TryParse(data[1], out decimal labGrade))
                        && (decimal.TryParse(data[2], out decimal testGrade)))
                        {
                            //Create a new student object
                            Student student = new Student
                            {
                                Name =      data[0],
                                LabGrade =  labGrade,
                                TestGrade = testGrade
                            };

                            //Add the stuent object to
                            //the List of Students
                            students.Add(student);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return students;
        }

        static Student SearchForStudent(List <Student> students, string searchName)
        {   
            return students.FirstOrDefault(
                s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
        }

        static decimal CalculateOverallGrade(Student student)
        {
            return (student.LabGrade * 0.4m) + (student.TestGrade * 0.6m);
        }

        static bool Again()
        {
            bool result = true;
            string yesOrNo = "";
            char firstChar = ' ';

            Console.Write("Run Program Again? Y/N ");
            Console.ReadLine();

            if (yesOrNo.Trim() != "")
            {
                firstChar = yesOrNo[0];

                if (firstChar != 'Y' && firstChar != 'y')
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
