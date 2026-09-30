using System.ComponentModel.DataAnnotations;

namespace MetaBiliş.Models
{
    public class Kullanici

    {
        public string KullaniciAdi { get; set; } = "";
        // veya string.Empty;

        [Key] // Bu satır KullaniciID'nin anahtar olduğunu belirtir
        public int KullaniciID { get; set; }

    }
}