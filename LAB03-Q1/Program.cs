using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_Q1
{
    public class Course
    {
      
        private string courseName;
        private string instructorName;
        private double grade;


        public string CourseName
        {
            get { return courseName; }
        }

        public double Grade
        {
            get { return grade; }
        }


        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(instructorName);
            SetGrade(grade);
        }


        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrWhiteSpace(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty or null.");
            }

            this.instructorName = instructorName;
        }

        private void SetGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }

            this.grade = grade;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

      
        public void PrintCourseInfo()
        {
            string letterGrade = CalculateLetterGrade();
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Instructor: {instructorName}");
            Console.WriteLine($"Grade: {letterGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Course course = new Course("Computer Science", "Dr. Smith", 85.5);
            course.PrintCourseInfo();
            Console.ReadLine();
        }
    }
}

