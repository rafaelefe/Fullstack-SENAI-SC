using exercicio_01_10.Model;
using Microsoft.EntityFrameworkCore;

namespace exercicio_01_10.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {
            
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDiscipline> StudentsDisciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

        public List<Student> ObterListaStudents()
        {
            return Students.ToList();
        }
        public List<Teacher> ObterListaTeachers()
        {
            return Teachers.ToList();
        }
        public List<Discipline> ObterListaDisciplines()
        {
            return Disciplines.ToList();
        }
        public List<StudentDiscipline> ObterListaStudentDisc()
        {
            return StudentsDisciplines.ToList();
        }
        public List<Quiz> ObterListaQuiz()
        {
            return Quizs.ToList();
        }
        public List<Question> ObterListaQuestion()
        {
            return Questions.ToList();
        }
        public List<Answer> ObterListaAnswer()
        {
            return Answers.ToList();
        }
    }
}
