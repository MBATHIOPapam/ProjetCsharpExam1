using System.ComponentModel.DataAnnotations;

namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Libelle { get; set; } = string.Empty;
        
        [Required]
        public int QuantiteEnStock { get; set; }
        
        [Required]
        public decimal PrixUnitaire { get; set; }
        
        [Required]
        public int QuantiteSeuil { get; set; }
        
        public string? Images { get; set; }
    }
}
