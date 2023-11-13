using Microsoft.EntityFrameworkCore;

namespace FormularioEstudiantes.Formulario.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Career> Careers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=students_example;User=root;Password=root;");
        }
    }
}
