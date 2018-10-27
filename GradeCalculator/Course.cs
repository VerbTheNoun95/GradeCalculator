using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    public enum LetterGrades
    {
        A,
        A_Minus,
        B_Plus,
        B,
        B_Minus,
        C_Plus,
        C,
        D,
        F
    }

    class Course
    {
        public int Weight;
        public int Average;
        public string Grade;

        // Compute the weighted average from user input grades
        public int WeightedAverager(List<int> points)
        {
            foreach(int grade in points)
            {

            }
            return Average;
        }

        /* Find letter grade corresponding to weighted average
         Letter grade comes from enum LetterGrades */
        public string LetterGrade(int WeightedAverager)
        {
            return Grade;
        }

        public class PSY513 : Course
        {
            
        }

        public class STA502 : Course
        {

        }

        public class STA503 : Course
        {

        }
    }
}
