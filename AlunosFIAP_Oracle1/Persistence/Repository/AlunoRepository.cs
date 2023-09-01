using AlunosFIAP_Oracle1.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosFIAP_Oracle1.Persistence.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly OracleDbContext _dbContext;

        public AlunoRepository(OracleDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public Alunos GetById(int id)
        {
            return _dbContext.Alunos.Find(id);
        }

        public IEnumerable<Alunos> GetAll()
        {
            return _dbContext.Alunos.ToList();
        }

        public void Add(Alunos entity)
        {
            _dbContext.Alunos.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Alunos entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Alunos entity)
        {
            _dbContext.Alunos.Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}
