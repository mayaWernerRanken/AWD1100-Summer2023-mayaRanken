using Microsoft.Win32;
using StudentGradeLibrary2;
using System;
using System.Collections.Generic;
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
                                "C:\\Users\\jemel\\OneDrive\\Documents\\GitHub\\AWD1100-Summer2023-mayaRanken\\demos");
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
                        string[] data = line.Split(',');

                        if ((data.Length == 3)
                        && (decimal.TryParse(data[1], out decimal labGrade))
                        && (decimal.TryParse(data[2], out decimal testGrade)))
                        {
                            Student student = new Student
                            {
                                Name = data[0],
                                LabGrade = labGrade,
                                TestGrade = testGrade
                            };

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
    }
}
