using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook boletin = new GradeBook();
            boletin.AddGrades(91);
            boletin.AddGrades(89.5f);
            boletin.AddGrades(75);

            Estadisticas estadisticas = boletin.ComputarEstadisticas();
            
            Console.WriteLine("Promedio: " + estadisticas.AverageGrade + " de notas del curso de NetCore");
            Console.WriteLine("Promedio2: {0:F2}", estadisticas.AverageGrade);
            Console.WriteLine("Mas alta: {0} de notas del {1} curso de NetCore", estadisticas.HighestGrade, "");
            Console.WriteLine($"Mas baja: {estadisticas.LowestGrade}");
            string mensaje = string.Format("Mas baja {0}", estadisticas.LowestGrade);

            Console.WriteLine(GradeBook.MinGrade());
        }
    }
}
