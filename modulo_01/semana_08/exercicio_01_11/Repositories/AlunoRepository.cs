using Escola.Dto;
using Escola.Models;

namespace Escola.Repositories
{
    public class AlunoRepository
    {
        // exercicio 5
        private static List<AlunoModel> lista = new List<AlunoModel>()
        {
            new AlunoModel { Id = 1, Nome = "Jorge", DataDeNascimento = new DateTime(2000-12-12)},
            new AlunoModel { Id = 2, Nome = "Ana", DataDeNascimento= new DateTime(2001-03-04)},
            new AlunoModel { Id = 3, Nome = "Pedro", DataDeNascimento = new DateTime(2003-12-03)}
        };
        // exercicio 6
        public List<AlunoModel> ListarAlunos(string? filtroNome)
        {

            if (string.IsNullOrEmpty(filtroNome))
                return lista;
            else
                return lista.Where(z => z.Nome.ToLower().Contains(filtroNome.ToLower()))
                .OrderBy(x => x.Id)
                .ToList();
        }

        // exercicio 9
        public AlunoModel ObterAlunos (int id)
        {
            return lista.FirstOrDefault(x => x.Id == id);
        }

        // exercicio 10
        public AlunoModel CriarAluno(CriarAlunoDto dto)
        {
            var aluno = new AlunoModel();
            aluno.Id = GerarId();
            aluno.Nome = dto.Nome;
            aluno.DataDeNascimento = dto.DataDeNascimento;
            aluno.DataDeInclusao = DateTime.Now;

            lista.Add(aluno);
            return aluno;
        }

        // exercicio 11
        public void ExcluirAluno(int id)
        {
            var aluno = lista.FirstOrDefault(x => x.Id == id);

            if (aluno != null)
                lista.Remove(aluno);
        }

        private int GerarId()
        {
            return lista.Last().Id + 1;
        }
    }
}
