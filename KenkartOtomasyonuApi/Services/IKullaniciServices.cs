using KenkartOtomasyonuApi.Dtos;
using KenkartOtomasyonuApi.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace KenkartOtomasyonuApi.Services
{
    public interface IKullaniciServices
    {
        List<Kullanici> GetTumKullanicilar();
        void KullaniciEkle(KullaniciEkle kullanici);
        void KullaniciGüncelle(KullaniciGüncelle kullanici);
        void KullaniciSil(int id);

    }
}
