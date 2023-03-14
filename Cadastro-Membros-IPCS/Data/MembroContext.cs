using Cadastro_Membros_IPCS.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_Membros_IPCS.Data;

public class MembroContext : DbContext 
{
    public MembroContext(DbContextOptions<MembroContext> opts) : base(opts)
    {

    }

    public DbSet<Membro> Membros { get; set; }
}
