using Microsoft.EntityFrameworkCore;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=projetcsharpexam;User Id=root;Password=your_password_here;", new MySqlServerVersion(new Version(8, 0, 33)));
            }
        }

        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Commande> Commandes { get; set; } = null!;
        public DbSet<Produit> Produits { get; set; } = null!;
        public DbSet<Livreur> Livreurs { get; set; } = null!;
        public DbSet<Livraison> Livraisons { get; set; } = null!;
        public DbSet<Paiement> Paiements { get; set; } = null!;
        public DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
    }
}
