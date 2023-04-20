using exercicio_01_10.Model;

namespace exercicio_01_10.DTOs
{
    public class StudentDto : UserDto
    {
        public int Period { get; set; }
        public int RA { get; set; }
    }
}
