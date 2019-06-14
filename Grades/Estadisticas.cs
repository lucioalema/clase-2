namespace Grades
{
    public class Estadisticas
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
        public Estadisticas()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public Estadisticas(float max, float min)
        {
            HighestGrade = max;
            LowestGrade = min;
        }
    }
}