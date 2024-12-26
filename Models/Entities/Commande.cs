using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime? Date { get; set; } = DateTime.Now;
        
        [Required]
        public decimal? Montant { get; set; } = 0;
        
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public List<Produit> Produits { get; set; } = new List<Produit>(); // Initialized to an empty list
        
        public bool EstComplete { get; set; }
public bool EstRecu { get; set; } // New property to track received status
        public bool EstMiseEnAttente { get; set; }
    }
}
