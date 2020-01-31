using System.Collections.Generic;

namespace linq_practice.Models
{
    public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
    public class Student
    {
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public GradeLevel Year;
        public List<int> ExamScores;
    }
}