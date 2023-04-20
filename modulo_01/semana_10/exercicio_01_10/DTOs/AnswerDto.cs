namespace exercicio_01_10.DTOs
{
    public class AnswerDto
    {
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string Answers { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }
    }
}
