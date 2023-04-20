namespace exercicio_01_10.Model
{
    public class Teacher
    {
        public int UserId { get; set; }
        public string Department { get; set; }
        public virtual User User { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
    }
}
