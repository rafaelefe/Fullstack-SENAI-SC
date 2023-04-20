namespace exercicio_01_10.Model
{
    public class Discipline
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string Disciplines { get; set; }
        public virtual Teacher Teacher { get; set; }
        public ICollection<Quiz> Quizs { get; set; }
        public ICollection<StudentDiscipline> StudentsDisciplines { get; set; }
    }
}
