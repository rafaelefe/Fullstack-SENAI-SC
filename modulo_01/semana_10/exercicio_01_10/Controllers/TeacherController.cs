using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class TeacherController : ControllerBase
    {
        private SchoolContext _context;

        public TeacherController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(TeacherDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teacher = new Teacher();
            teacher.Department = dto.Department;

            var user = new User();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.CPF = dto.CPF;
            user.Password = dto.Password;

            _context.Teachers.Add(teacher);
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { teacher, user });
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, TeacherDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var teacher = _context.Teachers.FirstOrDefault(x => x.UserId.Equals(id));
            if (teacher == null)
            {
                return NotFound();
            }

            teacher.Department = dto.Department;

            var user = new User();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.CPF = dto.CPF;
            user.Password = dto.Password;

            _context.Teachers.Update(teacher);
            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(new { teacher, user });
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var teacher = _context.ObterListaTeachers();

            return Ok(teacher);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(x => x.UserId == id);

            if (teacher == null)
            {
                return NotFound();
            }

            return Ok(teacher);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(x => x.UserId == id);

            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}

