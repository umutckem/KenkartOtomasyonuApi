# KentKart Otomasyonu API

KentKart kullanıcı yönetimi için geliştirilmiş modern bir .NET 8.0 Web API projesi.

## 🚀 Proje Hakkında

Bu proje, KentKart otomasyon sistemi için kullanıcı yönetimi işlemlerini gerçekleştiren RESTful API servisidir. Kullanıcıların eklenmesi, güncellenmesi, silinmesi ve listelenmesi gibi temel CRUD operasyonlarını destekler.

## ✨ Özellikler

- **Kullanıcı Yönetimi**: Tam CRUD operasyonları
- **Modern .NET**: .NET 8.0 ile en güncel teknolojiler
- **Veritabanı**: SQL Server + Entity Framework Core 8.0
- **API Dokümantasyonu**: Swagger/OpenAPI entegrasyonu
- **Katmanlı Mimari**: Service Layer pattern
- **Minimal API**: Modern endpoint tanımlama yaklaşımı

## 🛠️ Teknoloji Stack

- **Framework**: .NET 8.0
- **Web Framework**: ASP.NET Core
- **ORM**: Entity Framework Core 8.0.7
- **Veritabanı**: SQL Server
- **API Dokümantasyonu**: Swashbuckle.AspNetCore 6.6.2
- **Mimari**: Service Layer Pattern

## 📁 Proje Yapısı

```
KenkartOtomasyonuApi/
├── Models/                 # Veri modelleri
│   └── Kullanici.cs      # Kullanıcı entity modeli
├── Dtos/                  # Data Transfer Objects
│   ├── KullaniciEkle.cs  # Kullanıcı ekleme DTO'su
│   └── KullaniciGüncelle.cs # Kullanıcı güncelleme DTO'su
├── Services/              # İş mantığı katmanı
│   ├── IKullaniciServices.cs # Kullanıcı servis interface'i
│   └── KullaniciServices.cs  # Kullanıcı servis implementasyonu
├── Efcore/                # Veritabanı context
│   └── KentKartOtomasyonuEklemeDbContext.cs
├── Migrations/            # Entity Framework migrations
└── Program.cs             # Ana uygulama konfigürasyonu
```

## 🗄️ Veritabanı Modeli

### Kullanıcı (Kullanici) Tablosu

| Alan | Tip | Açıklama |
|------|-----|----------|
| Id | int | Birincil anahtar |
| KentKartId | double | KentKart kimlik numarası |
| Ad | string | Kullanıcı adı |
| Soyad | string | Kullanıcı soyadı |
| Yetki | string | Kullanıcı yetki seviyesi |
| ProfilResmi | string | Profil resmi dosya yolu |
| Password | string | Şifre |
| TelefonNo | double | Telefon numarası |
| Bakiye | float | Kart bakiyesi |
| KayitTarihi | DateTime | Kayıt tarihi |

## 🔌 API Endpoints

### Kullanıcı İşlemleri

| HTTP Metodu | Endpoint | Açıklama |
|-------------|----------|----------|
| GET | `/Kullanici` | Tüm kullanıcıları listele |
| POST | `/Kullanici` | Yeni kullanıcı ekle |
| PUT | `/Kullanici` | Kullanıcı bilgilerini güncelle |
| DELETE | `/Kullanici` | Kullanıcı sil (ID parametresi ile) |

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 veya VS Code

### Kurulum Adımları

1. **Projeyi klonlayın**
   ```bash
   git clone [repository-url]
   cd KenkartOtomasyonuApi
   ```

2. **Veritabanı bağlantısını yapılandırın**
   - `Efcore/KentKartOtomasyonuEklemeDbContext.cs` dosyasında connection string'i güncelleyin
   - Varsayılan connection string:
     ```csharp
     "Server=.;Database=KentKartOtoamasyonu;User Id=personel;Password=123456;TrustServerCertificate=true"
     ```

3. **Veritabanını oluşturun**
   ```bash
   dotnet ef database update
   ```

4. **Projeyi çalıştırın**
   ```bash
   dotnet run
   ```

5. **Swagger UI'a erişin**
   - Tarayıcınızda `https://localhost:5001/swagger` adresine gidin

## 📊 Veritabanı Migration'ları

Proje aşağıdaki migration'ları içerir:
- `20240829144229_KentKartOtomasyonuDataBase` - İlk veritabanı oluşturma
- `20250423130851_DataBaseV1` - Veritabanı v1 güncellemesi
- `20250423193858_DataBaseV1.01` - Veritabanı v1.01 güncellemesi

## 🔧 Geliştirme

### Yeni Migration Ekleme
```bash
dotnet ef migrations add [MigrationName]
```

### Veritabanını Güncelleme
```bash
dotnet ef database update
```

### Migration'ları Geri Alma
```bash
dotnet ef database update [PreviousMigrationName]
```

## 📝 Kullanım Örnekleri

### Kullanıcı Ekleme
```http
POST /Kullanici
Content-Type: application/json

{
  "id": 1,
  "kentKartId": 123456789,
  "ad": "Ahmet",
  "soyad": "Yılmaz",
  "yetki": "Kullanıcı",
  "profilResmi": "profile1.jpg",
  "password": "123456",
  "telefonNo": 5551234567,
  "bakiye": 100.50
}
```

### Kullanıcı Güncelleme
```http
PUT /Kullanici
Content-Type: application/json

{
  "id": 1,
  "kentKartId": 123456789,
  "ad": "Ahmet",
  "soyad": "Yılmaz",
  "profilResmi": "profile1_updated.jpg",
  "password": "newpassword",
  "telefonNo": 5551234567,
  "bakiye": 150.75
}
```

### Kullanıcı Silme
```http
DELETE /Kullanici?id=1
```

## 🧪 Test

Proje HTTP dosyası (`KenkartOtomasyonuApi.http`) ile test edilebilir. Bu dosya REST Client eklentisi ile kullanılabilir.

## 📋 TODO ve Geliştirme Önerileri

- [ ] Authentication ve Authorization ekleme
- [ ] Input validation ve error handling geliştirme
- [ ] Logging mekanizması ekleme
- [ ] Unit test'ler yazma
- [ ] API rate limiting ekleme
- [ ] Caching mekanizması ekleme
- [ ] API versioning ekleme

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 📞 İletişim

Proje hakkında sorularınız için issue açabilir veya [email] adresinden ulaşabilirsiniz.

---

**Not**: Bu proje geliştirme aşamasındadır ve production ortamında kullanılmadan önce güvenlik testlerinden geçirilmelidir.