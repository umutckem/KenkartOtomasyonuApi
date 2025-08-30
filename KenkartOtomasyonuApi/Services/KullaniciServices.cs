using KenkartOtomasyonuApi.Dtos;
using KenkartOtomasyonuApi.Efcore;
using KenkartOtomasyonuApi.Models;

namespace KenkartOtomasyonuApi.Services
{
    public class KullaniciServices : IKullaniciServices
    {
        private readonly KentKartOtomasyonuEklemeDbContext _dbContext;

        public KullaniciServices()
        {
            _dbContext = new KentKartOtomasyonuEklemeDbContext();
        }
        public List<Kullanici> GetTumKullanicilar()
        {
            var Kullanicilar = _dbContext.kullanicilar.ToList();
            return Kullanicilar;
        }

        public void KullaniciEkle(KullaniciEkle kullanici)
        {
            kullanici.KayitTarihi = DateTime.Now;

            var yeniKullanici = new Kullanici
            {
                Ad = kullanici.Ad,
                Bakiye = kullanici.Bakiye,
                Soyad = kullanici.Soyad,
                Yetki = kullanici.Yetki,
                ProfilResmi = kullanici.ProfilResmi,
                Id = kullanici.Id,
                KayitTarihi = kullanici.KayitTarihi,
                KentKartId = kullanici.KentKartId,
                Password = kullanici.Password,
                TelefonNo = kullanici.TelefonNo,
            };
            _dbContext.kullanicilar.Add(yeniKullanici);
            _dbContext.SaveChanges();
        }

        public void KullaniciGüncelle(KullaniciGüncelle kullanici)
        {
            var Kullanici = _dbContext.kullanicilar.Find(kullanici.Id);
            if (Kullanici != null)
            {
                Kullanici.Id = kullanici.Id;
                Kullanici.Ad = kullanici.Ad;
                Kullanici.Soyad = kullanici.Soyad;
                Kullanici.ProfilResmi = kullanici.ProfilResmi;
                Kullanici.Bakiye = kullanici.Bakiye;
                Kullanici.KentKartId = kullanici.KentKartId;
                Kullanici.Password = kullanici.Password;
                Kullanici.TelefonNo = kullanici.TelefonNo;

                _dbContext.SaveChanges();
            }
        }

        public void KullaniciSil(int id)
        {

            var silinecekKullanici = _dbContext.kullanicilar.Find(id);
            if (silinecekKullanici != null)
            {
                _dbContext.kullanicilar.Remove(silinecekKullanici);
                _dbContext.SaveChanges();

            }
        }
    }
}
