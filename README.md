# 🧩 MetaBiliş

Blazor Server tabanlı bir metabilişsel test ve değerlendirme uygulaması. Kullanıcıların kendi düşünme süreçlerine dair farkındalıklarını ölçer; istatistiksel olarak Brier skoru ve Yönelim (Bias) analizi ile değerlendirir.

##  Özellikler
* **Metabilişsel Test Çözme:** Doğru/Yanlış ve Çoktan Seçmeli sorularla dinamik test ekranı.
*  **Brier Skoru ile Güven Kalibrasyonu:** Öğrencilerin verdikleri cevaplardan "ne kadar emin olduklarını" analiz eden bilimsel değerlendirme.
*  **Bilişsel Yönelim (Bias) Tespiti:** Aşırı Özgüven (Overconfidence) veya Düşük Özgüven (Underconfidence) durumlarının algoritmik tespiti.
*  **Gelişmiş Admin Paneli:** Test/soru yönetimi (CRUD) ve tek tuşla tüm soruları temizleme.
*  **Toplu Soru Aktarımı:** Özel ayırıcılı (`|`) .txt dosyaları ile yüzlerce soruyu saniyeler içinde sisteme yükleme.
*  **Minimalist Tasarım:** Glass-morphism etkili, modern ve kullanıcı dostu arayüz.

## 🛠️ Teknolojiler
| Teknoloji | Versiyon |
| :--- | :--- |
| **.NET** | 8.0 |
| **Blazor** | Server-Side |
| **ORM** | Entity Framework Core |
| **Veritabanı** | SQLite |
| **Arayüz** | Bootstrap 5.x / Custom CSS |
| **Dil** | C# 12 |

## 📁 Proje Yapısı
```text
MetaBilis/
├── wwwroot/
│   ├── bootstrap/
│   └── app.css
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor
│   ├── Pages/
│   │   ├── Admin.razor         # Yönetim ve .txt yükleme paneli
│   │   ├── Home.razor          # Ana sayfa ve test seçimi
│   │   ├── Sonuc.razor         # Sonuç, Brier skoru ve Bias analizi
│   │   └── TestCoz.razor       # Eminlik puanlı test ekranı
├── Migrations/                 # EF Core veritabanı göç dosyaları
├── Models/
│   ├── KullaniciCevabi.cs
│   ├── Soru.cs
│   ├── Test.cs
│   └── UygulamaDbContext.cs    # EF Core veritabanı bağlamı
├── metabilişsel.db             # Taşınabilir SQLite veritabanı
└── Program.cs
```

## Brier Skoru ve Metabilişsel Analiz Nedir?
Brier skoru, bir öğrencinin tahmin güveni (eminlik) ile gerçeklik (doğruluk) arasındaki kalibrasyonu ölçer.

**BS = (1/N) × Σ (Güven - Doğruluk)²**

Uygulamamızdaki değerlendirme kriterleri:
* **< 0.15** → Mükemmel kalibrasyon (Ne bildiğini tam olarak biliyor)
* **0.15 - 0.30** → İyi farkındalık, ufak sapmalar
* **> 0.30** → Zayıf Kalibrasyon. Bu noktada sistem **Bias (Yönelim)** hesaplar:
  * *Eğilim > 0 :* Aşırı Özgüven (Yanlış biliyor ama çok emin)
  * *Eğilim < 0 :* Düşük Özgüven (Doğru biliyor ama kendine güvenmiyor)

##  Dosyadan (.txt) Soru Yükleme Formatı
Yönetici panelinden soru yüklerken metin belgeniz şu formatta olmalıdır:
* **D/Y:** `DogruYanlis | Soru Cümlesi | Doğru`
* **Çoktan Seçmeli:** `CoktanSecmeli | Soru Cümlesi | A Şıkkı | B Şıkkı | C Şıkkı | D Şıkkı | A`

##  Sayfalar
| Sayfa | Açıklama |
| :--- | :--- |
| `/` | Ana sayfa ve testlerin listelendiği ekran |
| `/testcoz/{TestId}/{KullaniciId}` | Güven kaydırıcısına (slider) sahip test çözme arayüzü |
| `/sonuc/{KullaniciId}` | Metabilişsel kalibrasyonun ve başarı oranının raporlandığı ekran |
| `/admin` | Şifre korumalı soru/test yönetim ve dosya yükleme paneli |

##  Lisans
Bu proje **MIT** lisansı ile lisanslanmıştır.
