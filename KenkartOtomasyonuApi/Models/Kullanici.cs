﻿namespace KenkartOtomasyonuApi.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public double KentKartId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yetki { get; set; }
        public string ProfilResmi { get; set; }
        public string Password { get; set; }
        public double TelefonNo { get; set; }
        public float Bakiye { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
