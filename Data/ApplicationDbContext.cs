using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeuApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<MeuApp.Models.Alunos> Alunos { get; set; } = default!;
    public DbSet<MeuApp.Models.Professores> Professores { get; set; } = default!;
}
