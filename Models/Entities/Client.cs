using System.ComponentModel.DataAnnotations;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Nom { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string? Prenom { get; set; } = string.Empty;
        
        [Required]
        [StringLength(15)]
        public string? Telephone { get; set; } = string.Empty;
        
        [Required]
        [StringLength(200)]
        public string? Adresse { get; set; } = string.Empty;
        
        public decimal SoldeCompte { get; set; }
    }
}
