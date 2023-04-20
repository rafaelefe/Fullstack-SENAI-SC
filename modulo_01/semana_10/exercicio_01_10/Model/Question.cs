namespace exercicio_01_10.Model
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        public virtual Quiz Quiz { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
