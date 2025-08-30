
using KenkartOtomasyonuApi.Dtos;
using KenkartOtomasyonuApi.Services;

namespace KenkartOtomasyonuApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapGet("/Kullanici", () => 
            {

                IKullaniciServices kullaniciServices = new KullaniciServices();

                return kullaniciServices.GetTumKullanicilar();

            });

            app.MapPost("/Kullanici", (KullaniciEkle kullanici) =>
            {
                IKullaniciServices kullaniciServices = new KullaniciServices();
                kullaniciServices.KullaniciEkle(kullanici);
            });

            app.MapPut("/Kullanici", (KullaniciGüncelle kullanici) => {
                IKullaniciServices kullaniciServices = new KullaniciServices();
                kullaniciServices.KullaniciGüncelle(kullanici);
            });

            app.MapDelete("/Kullanici", (int id) => {
                IKullaniciServices kullaniciServices = new KullaniciServices();
                kullaniciServices.KullaniciSil(id);
            });
            
            
            app.Run();
        }
    }
}
