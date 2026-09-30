namespace MetaBiliş.Models
{
    public class KullaniciCevabi
    {
        public int Id { get; set; }
        public int KullaniciID { get; set; } // Hangi öğrenci çözdü? (Örn: İzzel)
        public int SoruId { get; set; } // Hangi soruya cevap verdi?
        public string VerilenCevap { get; set; }
        public bool IsDogru { get; set; } // Gerçekten bildi mi? (True/False)
        public int EminlikPuani { get; set; } // Öğrencinin seçtiği %10 ile %100 arası değer
    }
}