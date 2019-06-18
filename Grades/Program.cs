using System;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook boletin = new GradeBook();
            boletin.NameChanged += new NameChangedDelegate(OnNameChanged);
            boletin.NameChanged += new NameChangedDelegate(OnNameChanged2);
            boletin.LastName = "Molina";
            boletin.LastName = "Cruz";
            boletin.LastName = "Cruz";
            boletin.AddGrades(91);
            boletin.AddGrades(89.5f);
            boletin.AddGrades(75);

            // Estadisticas estadisticas = boletin.ComputarEstadisticas();
            
            // Console.WriteLine("Promedio: " + estadisticas.AverageGrade + " de notas del curso de NetCore");
            // Console.WriteLine("Promedio2: {0:F2}", estadisticas.AverageGrade);
            // Console.WriteLine("Mas alta: {0} de notas del {1} curso de NetCore", estadisticas.HighestGrade, "");
            // Console.WriteLine($"Mas baja: {estadisticas.LowestGrade}");
            // string mensaje = string.Format("Mas baja {0}", estadisticas.LowestGrade);

            // Console.WriteLine(GradeBook.MinGrade());


            // GradeBook boletin2 = new GradeBook("Luis");
            // boletin2.LastName = "Cornejo";
            // Console.WriteLine("Apellido {0}", boletin2.LastName);
            //Iteradores();
            //Condicionales();
        }

        static void Iteradores()
        {
            List<int> years = new List<int>();
            years.Add(2);
            years.Add(5);
            years.Add(10);
            int[] yearsArray = years.ToArray();
            int[] array = new int[] { 1,2,3 };
            foreach(int y in yearsArray)
            {
                if (y == 5)
                    continue;
                else
                    Console.WriteLine(y + " - ");
                Console.WriteLine("Continua");
            }
            // for(int i=0; i<yearsArray.Length; i++)
            // {
            //     Console.WriteLine(yearsArray[i] + " - ");
            // }
            // int age = 5;
            // while(age > 0)
            // {
            //     Console.WriteLine(age);
            //     age--;
            // }
            // age = 5;
            // do{
            //     Console.WriteLine(age);
            //     age--;
            // }while(age > 0);
        }

        static void Condicionales()
        {
            int age = 5;
            string menorDeEdad = "";
            if (age < 18)
                menorDeEdad = "SI";
            else
                menorDeEdad = "NO";
            Console.WriteLine(menorDeEdad);

            string saludo = "hola";
            switch (saludo)
            {
                case "hola":
                    Console.WriteLine(saludo);
                    break;
                default:
                    Console.WriteLine("Chau");
                    break;
            }
        }
        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine("El apellido cambio de {0} a {1}", existingName, newName);
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("**");
        }
    }
}
