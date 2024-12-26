namespace ProjetCsharpExamMbathio.Models.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string? Nom { get; set; } = string.Empty;
        public string? Prenom { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
    }
}
