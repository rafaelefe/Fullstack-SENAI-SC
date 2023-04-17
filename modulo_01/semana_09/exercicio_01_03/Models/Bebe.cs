namespace Bercario.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal PesoNascimento { get; set; }
        public int Altura { get; set; }
        public int MaeId { get; set; }
        public int PartoId { get; set; }
        public virtual Mae Mae { get; set; }
        public virtual Parto Parto { get; set; }
    }
}
