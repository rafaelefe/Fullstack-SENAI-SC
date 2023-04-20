using exercicio_01_10.Context;
using exercicio_01_10.DTOs;
using exercicio_01_10.Model;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_01_10.Controllers
{
    public class DisciplineController : ControllerBase
    {
        private SchoolContext _context;

        public DisciplineController(SchoolContext context)
        {
            _context = context;
        }

        //Criar
        [HttpPost]
        public IActionResult Criar(DisciplineDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var discipline = new Discipline();
            discipline.TeacherId = dto.TeacherId;
            discipline.Disciplines = dto.Disciplines;

            _context.Disciplines.Add(discipline);
            _context.SaveChanges();

            return Ok(discipline);
        }

        //Atualizar
        [HttpPut("{Id}")]
        public IActionResult Atualizar(int id, DisciplineDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var discipline = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
            if (discipline == null)
            {
                return NotFound();
            }

            discipline.TeacherId = dto.TeacherId;
            discipline.Disciplines = dto.Disciplines;

            _context.Disciplines.Update(discipline);
            _context.SaveChanges();

            return Ok(discipline);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            var discipline = _context.ObterListaDisciplines();

            return Ok(discipline);
        }

        //Obter pro Id
        [HttpGet("{codigo}")]
        public IActionResult ObterId([FromRoute] int id)
        {
            var discipline = _context.Disciplines.FirstOrDefault(x => x.Id == id);

            if (discipline == null)
            {
                return NotFound();
            }

            return Ok(discipline);
        }

        //Excluir
        [HttpDelete("{codigo}")]
        public IActionResult Excluir(int id)
        {
            var discipline = _context.Disciplines.FirstOrDefault(x => x.Id == id);

            if (discipline == null)
            {
                return NotFound();
            }
            else
            {
                _context.Disciplines.Remove(discipline);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }
}
