using System.ComponentModel.DataAnnotations;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Livreur
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
    }
}
