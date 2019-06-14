using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        private List<float> grades;

        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        public Estadisticas ComputarEstadisticas()
        {
            Estadisticas estadisticas = new Estadisticas();
            float sum = 0;
            foreach(float grade in grades)
            {
                estadisticas.HighestGrade = Math.Max(grade, estadisticas.HighestGrade);
                estadisticas.LowestGrade = Math.Min(grade, estadisticas.LowestGrade);
                sum += grade;
            }
            if (grades.Count > 0)
                estadisticas.AverageGrade = sum / grades.Count;
            return estadisticas;
        }

        public static float MinGrade()
        {
            return float.MinValue;
        }
    }
}