using Microsoft.EntityFrameworkCore;
using System;


namespace Alura.Loja.Testes.ConsoleApp
{
    internal class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PC-WILLIAN\MSSQLSERVER01;Initial Catalog=LojaDB;Integrated Security=True");
        }
    }
}
