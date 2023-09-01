using AlunosFIAP_Oracle1.Models;

namespace AlunosFIAP_Oracle1.Persistence.Repository
{
    public interface IAlunoRepository
    {
        Alunos GetById(int id);
        IEnumerable<Alunos> GetAll();
        void Add(Alunos entity);
        void Update(Alunos entity);
        void Delete(Alunos entity);

    }
}
