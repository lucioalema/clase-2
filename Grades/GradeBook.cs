using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        private List<float> grades;
        private readonly string _name;

        private string _lastName;
        public string LastName
        {
            get { 
                return _lastName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_lastName != value)
                    {
                        NameChanged(_lastName, value);
                        _lastName = value;
                    }
                }

            }
        }
        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeBook(string name)
        {
            grades = new List<float>();
            _name = name;
        }

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
        public NameChangedDelegate NameChanged;
    }
}