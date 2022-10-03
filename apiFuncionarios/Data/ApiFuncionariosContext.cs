using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiFuncionarios.Models;

namespace ApiFuncionarios.Data
{
    public class ApiFuncionariosContext : DbContext
    {
        public ApiFuncionariosContext (DbContextOptions<ApiFuncionariosContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFuncionarios.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
