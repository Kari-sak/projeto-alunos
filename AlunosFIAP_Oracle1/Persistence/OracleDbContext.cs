using Microsoft.EntityFrameworkCore;
using AlunosFIAP_Oracle1.Models;

namespace AlunosFIAP_Oracle1.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet <Alunos> Alunos { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)  
        { 
            
        }
    }
}
