using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Livraison
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime? DateLivraison { get; set; } = DateTime.Now;
        
        [Required]
        [StringLength(200)]
        public string? AdresseLivraison { get; set; } = string.Empty;
        
        [ForeignKey("Commande")]
        public int CommandeId { get; set; }
        public Commande? Commande { get; set; } // Changed to nullable
        
        [ForeignKey("Livreur")]
        public int LivreurId { get; set; }
        public Livreur? Livreur { get; set; } // Changed to nullable
    }
}
