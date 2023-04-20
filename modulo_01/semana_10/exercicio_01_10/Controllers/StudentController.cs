using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private SchoolContext _context;

        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(StudentDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = new Student();
            student.Period = dto.Period;
            student.RA = dto.RA;

            var user = new User();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.CPF = dto.CPF;
            user.Password = dto.Password;

            _context.Students.Add(student);
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { student, user });
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, StudentDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var student = _context.Students.FirstOrDefault(x => x.UserId.Equals(id));
            if (student == null)
            {
                return NotFound();
            }

            student.Period = dto.Period;
            student.RA = dto.RA;

            var user = new User();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.CPF = dto.CPF;
            user.Password = dto.Password;

            _context.Students.Update(student);
            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(new { student, user });
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var student = _context.ObterListaStudents();

            return Ok(student);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.UserId == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.UserId == id);

            if (student == null)
            {
                return NotFound();
            }
            else
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}

