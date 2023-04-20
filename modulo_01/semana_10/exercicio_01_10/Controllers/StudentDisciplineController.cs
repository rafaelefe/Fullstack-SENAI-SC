using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class StudentDisciplineController : Controller
    {
        private SchoolContext _context;

        public StudentDisciplineController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(StudentDisciplineDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentdisc = new StudentDiscipline();
            studentdisc.StudentId = dto.StudentId;
            studentdisc.DisciplineId = dto.DisciplineId;

            _context.StudentsDisciplines.Add(studentdisc);
            _context.SaveChanges();

            return Ok(studentdisc);
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, StudentDisciplineDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var studentdisc = _context.StudentsDisciplines.FirstOrDefault(x => x.Id.Equals(id));
            if (studentdisc == null)
            {
                return NotFound();
            }

            studentdisc.StudentId = dto.StudentId;
            studentdisc.DisciplineId = dto.DisciplineId;

            _context.StudentsDisciplines.Update(studentdisc);
            _context.SaveChanges();

            return Ok(studentdisc);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var studentdisc = _context.ObterListaStudentDisc();

            return Ok(studentdisc);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var studentdisc = _context.StudentsDisciplines.FirstOrDefault(x => x.Id == id);

            if (studentdisc == null)
            {
                return NotFound();
            }

            return Ok(studentdisc);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var studentdisc = _context.StudentsDisciplines.FirstOrDefault(x => x.Id == id);

            if (studentdisc == null)
            {
                return NotFound();
            }
            else
            {
                _context.StudentsDisciplines.Remove(studentdisc);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}
