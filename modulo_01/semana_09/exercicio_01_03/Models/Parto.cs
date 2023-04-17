using System.ComponentModel.DataAnnotations;

namespace Bercario.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public DateTime DataParto { get; set; }
        public DateTime HorarioParto { get; set; }
        public int MedicoId { get; set; }
        public virtual Medico MedicoParto { get; set; }
        public ICollection<Bebe> Bebes { get; set; }
    }
}
