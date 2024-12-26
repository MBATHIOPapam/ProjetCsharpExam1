using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Paiement
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime DatePaiement { get; set; }
        
        [Required]
        public decimal Montant { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? Type { get; set; } = string.Empty; // e.g., OM, Wave, Chèque
        
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
