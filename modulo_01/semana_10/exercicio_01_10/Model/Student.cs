namespace exercicio_01_10.Model
{
    public class Student
    {
        public int UserId { get; set; }
        public int Period { get; set; }
        public int RA { get; set; }
        public virtual User User { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<StudentDiscipline> StudentDisciplines { get; set; }
    }
}
