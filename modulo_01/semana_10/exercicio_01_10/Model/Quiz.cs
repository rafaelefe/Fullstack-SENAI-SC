namespace exercicio_01_10.Model
{
    public class Quiz
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DateClose { get; set; }
        public virtual Discipline Discipline { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
