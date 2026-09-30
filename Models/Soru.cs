namespace MetaBiliş.Models
{
    public class Soru
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string SoruMetni { get; set; }
        public string SoruTipi { get; set; }
        public string DogruCevap { get; set; }

        // Çoktan seçmeli sorular için yeni alanlar
        public string SecenekA { get; set; } = "";
        public string SecenekB { get; set; } = "";
        public string SecenekC { get; set; } = "";
        public string SecenekD { get; set; } = "";
    }
}