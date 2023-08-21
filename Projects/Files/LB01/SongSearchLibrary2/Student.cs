using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeLibrary2
{
    public class Student
    {
        public string Name { get; set; }
        public decimal TestGrade { get; set; }
        public decimal LabGrade { get; set; }

        // No-Arg Constructor
        public Student() { }
    }
}
