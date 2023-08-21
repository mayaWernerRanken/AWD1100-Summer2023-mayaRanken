using StudentGradeLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Display from 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text;

            Student foundStudent = SearchForStudent(students, searchName);

            if (foundStudent != null)
            {
                decimal overallGrade = StudentOverallGrade(foundStudent);
                lblResult.Text = $"Student Name: {foundStudent.Name}\n" +
                                 $"Lab Grade: {foundStudent.LabGrade}\n" +
                                 $"Test Grade: {foundStudent.TestGrade}\n" +
                                 $"Overall Grade: {overallGrade:n2}";
            }
            else
            {
                MessageBox.Show($"{searchName} not found.", "ERROR");
            }
        }

        //Grab list from grades.txt
        List<Student> students = ReadStudentFromFile("C:\\Users\\jemel\\OneDrive\\Documents\\GitHub\\AWD1100-Summer2023-mayaRanken\\Projects\\Files\\LB01\\grades.txt");

        //Reads .txt file as list
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
                        //split line into fields [0], [1], and [2] (name, lab grade, and test grade respectively)
                        string[] data = line.Split(',');

                        if ((data.Length == 3) && (decimal.TryParse(data[1], out decimal labGrade)) && (decimal.TryParse(data[2], out decimal testGrade)))
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
            catch (Exception)
            {
                //Throw error message if grades.txt is not present
                MessageBox.Show("Text file not found.");
            }

            return students;
        }

        //
        static Student SearchForStudent(List<Student> students, string searchName)
        {
            return students.FirstOrDefault(s=>s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
        }

        //Calculate student grade
        static decimal StudentOverallGrade(Student student)
        {
            return (student.LabGrade * 0.4m) + (student.TestGrade * 0.6m);
        }
    }
}
