namespace exercicio_01_10.Model
{
    public class StudentDiscipline
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DisciplineId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}
