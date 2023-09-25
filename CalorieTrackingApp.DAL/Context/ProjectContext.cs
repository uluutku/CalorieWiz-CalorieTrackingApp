using CalorieTrackingApp.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalorieTrackingApp.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ConsumedFood> ConsumedFoods { get; set; }
        public DbSet<ConsumedWater> ConsumedWaters { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<SocialMediaPost> SocialMediaPosts { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<WeightHistory> WeightHistories { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<LikedAccount> LikedAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=****;Database=CalorieTrackingAppDB2;User Id=sa;Password=****");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Account>()
                .Property(u => u.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Account>()
               .Property(u => u.QuestionAnswer)
               .HasMaxLength(50);

            modelBuilder.Entity<Food>()
               .Property(u => u.Name)
               .HasMaxLength(50);

            modelBuilder.Entity<SecurityQuestion>()
               .Property(u => u.QestionText)
               .HasMaxLength(120);

            modelBuilder.Entity<SocialMediaPost>()
               .Property(u => u.PostDescription)
               .HasMaxLength(225);

            modelBuilder.Entity<SecurityQuestion>()
                .HasData(
                new SecurityQuestion() { Id = 1, QestionText = "En sevdiğiniz yemek nedir?" },
                new SecurityQuestion() { Id = 2, QestionText = "İlk evcil hayvanınızın adı nedir?" },
                new SecurityQuestion() { Id = 3, QestionText = "En sevdiğiniz spor nedir?" },
                new SecurityQuestion() { Id = 4, QestionText = "Hangi şehirde doğdunuz?" },
                new SecurityQuestion() { Id = 5, QestionText = "En sevdiğiniz çocukluk arkadaşınızın adı nedir?" },
                new SecurityQuestion() { Id = 6, QestionText = "Hangi okulda ilk kez öğrenim gördünüz?" },
                new SecurityQuestion() { Id = 7, QestionText = "En sevdiğiniz hayvan nedir?" }
                    );
            modelBuilder.Entity<Food>().HasData(
     new Food() { Id = 1, Name = "Köfte", StandartPortion = 100, PortionProtein = 25, PortionFat = 15, PortionCarb = 5, PortionCalorie = 300, Photo = CalorieTrackingApp.DAL.Properties.Resources.kofte},
     new Food() { Id = 2, Name = "Pilav", StandartPortion = 100, PortionProtein = 5, PortionFat = 10, PortionCarb = 50, PortionCalorie = 250, Photo = null},
     new Food() { Id = 3, Name = "Salata", StandartPortion = 100, PortionProtein = 2, PortionFat = 5, PortionCarb = 10, PortionCalorie = 70, Photo = null},
     new Food() { Id = 4, Name = "Balık", StandartPortion = 100, PortionProtein = 20, PortionFat = 10, PortionCarb = 0, PortionCalorie = 200, Photo = null},
     new Food() { Id = 5, Name = "Pasta", StandartPortion = 100, PortionProtein = 10, PortionFat = 15, PortionCarb = 40, PortionCalorie = 350, Photo = null},
     new Food() { Id = 6, Name = "Çorba", StandartPortion = 100, PortionProtein = 5, PortionFat = 5, PortionCarb = 15, PortionCalorie = 120, Photo = null },
     new Food() { Id = 7, Name = "Elma", StandartPortion = 100, PortionProtein = 0.5, PortionFat = 0.2, PortionCarb = 13, PortionCalorie = 52, Photo = null},
     new Food() { Id = 8, Name = "Muz", StandartPortion = 100, PortionProtein = 1.1, PortionFat = 0.3, PortionCarb = 27, PortionCalorie = 105, Photo = null},
     new Food() { Id = 9, Name = "Tavuk", StandartPortion = 100, PortionProtein = 32, PortionFat = 3.6, PortionCarb = 0, PortionCalorie = 165, Photo = null},
     new Food() { Id = 10, Name = "Somon", StandartPortion = 100, PortionProtein = 20, PortionFat = 13, PortionCarb = 0, PortionCalorie = 206, Photo = null},
     new Food() { Id = 11, Name = "Karnabahar", StandartPortion = 100, PortionProtein = 2, PortionFat = 0.5, PortionCarb = 5, PortionCalorie = 25, Photo = null},
     new Food() { Id = 12, Name = "Tavuk Kebabı", StandartPortion = 100, PortionProtein = 32, PortionFat = 4.1, PortionCarb = 0.5, PortionCalorie = 176, Photo = null},
     new Food() { Id = 13, Name = "Makarna", StandartPortion = 100, PortionProtein = 12, PortionFat = 1.3, PortionCarb = 71, PortionCalorie = 371, Photo = null},
     new Food() { Id = 14, Name = "Baklava", StandartPortion = 100, PortionProtein = 5.4, PortionFat = 40, PortionCarb = 65, PortionCalorie = 509, Photo = null},
     new Food() { Id = 15, Name = "Çikolata", StandartPortion = 100, PortionProtein = 5.5, PortionFat = 29, PortionCarb = 60, PortionCalorie = 546, Photo = null},
     new Food() { Id = 16, Name = "Yumurta", StandartPortion = 100, PortionProtein = 13, PortionFat = 11, PortionCarb = 1.1, PortionCalorie = 155, Photo = null},
     new Food() { Id = 17, Name = "Cips", StandartPortion = 100, PortionProtein = 6.7, PortionFat = 37, PortionCarb = 49, PortionCalorie = 536, Photo = null},
     new Food() { Id = 18, Name = "Brokoli", StandartPortion = 100, PortionProtein = 2.8, PortionFat = 0.6, PortionCarb = 11, PortionCalorie = 55, Photo = null},
     new Food() { Id = 19, Name = "Portakal", StandartPortion = 100, PortionProtein = 1, PortionFat = 0.2, PortionCarb = 8.3, PortionCalorie = 43, Photo = null},
     new Food() { Id = 20, Name = "Hindi", StandartPortion = 100, PortionProtein = 29, PortionFat = 1.5, PortionCarb = 0, PortionCalorie = 135, Photo = null},
     new Food() { Id = 21, Name = "Karides", StandartPortion = 100, PortionProtein = 20, PortionFat = 0.9, PortionCarb = 0, PortionCalorie = 85, Photo = null},
     new Food() { Id = 22, Name = "Sote", StandartPortion = 100, PortionProtein = 27, PortionFat = 13, PortionCarb = 4, PortionCalorie = 280, Photo = null},
     new Food() { Id = 23, Name = "Pizza", StandartPortion = 100, PortionProtein = 12, PortionFat = 11, PortionCarb = 32, PortionCalorie = 266, Photo = null},
     new Food() { Id = 24, Name = "Puding", StandartPortion = 100, PortionProtein = 2.7, PortionFat = 3.6, PortionCarb = 22, PortionCalorie = 127, Photo = null},
     new Food() { Id = 25, Name = "Kola", StandartPortion = 100, PortionProtein = 0, PortionFat = 0, PortionCarb = 11, PortionCalorie = 45, Photo = null},
     new Food() { Id = 26, Name = "Çay", StandartPortion = 100, PortionProtein = 0.1, PortionFat = 0, PortionCarb = 0, PortionCalorie = 1, Photo = null},
     new Food() { Id = 27, Name = "Meyve Salatası", StandartPortion = 100, PortionProtein = 0.9, PortionFat = 0.1, PortionCarb = 14, PortionCalorie = 56, Photo = null},
     new Food() { Id = 28, Name = "Pancar Salatası", StandartPortion = 100, PortionProtein = 1.6, PortionFat = 0.2, PortionCarb = 9.6, PortionCalorie = 43, Photo = null},
     new Food() { Id = 29, Name = "Fırın Tavuk", StandartPortion = 100, PortionProtein = 23, PortionFat = 3.6, PortionCarb = 0, PortionCalorie = 135, Photo = null},
     new Food() { Id = 30, Name = "Levrek", StandartPortion = 100, PortionProtein = 20, PortionFat = 9, PortionCarb = 0, PortionCalorie = 167, Photo = null},
     new Food() { Id = 31, Name = "Mantar Sote", StandartPortion = 100, PortionProtein = 3.1, PortionFat = 1.8, PortionCarb = 4.9, PortionCalorie = 36, Photo = null},
     new Food() { Id = 32, Name = "Mango", StandartPortion = 100, PortionProtein = 0.8, PortionFat = 0.6, PortionCarb = 14, PortionCalorie = 60, Photo = null},
     new Food() { Id = 33, Name = "Kuzu Şiş", StandartPortion = 100, PortionProtein = 25, PortionFat = 5, PortionCarb = 0, PortionCalorie = 151, Photo = null},
     new Food() { Id = 34, Name = "Roka Salatası", StandartPortion = 100, PortionProtein = 2.9, PortionFat = 0.3, PortionCarb = 2.2, PortionCalorie = 19, Photo = null},
     new Food() { Id = 35, Name = "Tavuk Salatası", StandartPortion = 100, PortionProtein = 28, PortionFat = 6, PortionCarb = 3, PortionCalorie = 188, Photo = null},
     new Food() { Id = 36, Name = "Karides Güveç", StandartPortion = 100, PortionProtein = 15, PortionFat = 5, PortionCarb = 5, PortionCalorie = 125, Photo = null},
     new Food() { Id = 37, Name = "Kuzu Tandır", StandartPortion = 100, PortionProtein = 32, PortionFat = 19, PortionCarb = 0, PortionCalorie = 325, Photo = null},
     new Food() { Id = 38, Name = "Pasta Salatası", StandartPortion = 100, PortionProtein = 2.8, PortionFat = 8, PortionCarb = 21, PortionCalorie = 160, Photo = null},
     new Food() { Id = 39, Name = "Cheesecake", StandartPortion = 100, PortionProtein = 6, PortionFat = 26, PortionCarb = 19, PortionCalorie = 321, Photo = null},
     new Food() { Id = 40, Name = "Kumpir", StandartPortion = 100, PortionProtein = 5.7, PortionFat = 12, PortionCarb = 33, PortionCalorie = 242, Photo = null},
     new Food() { Id = 41, Name = "Karnıyarık", StandartPortion = 100, PortionProtein = 5.4, PortionFat = 16, PortionCarb = 16, PortionCalorie = 224, Photo = null},
     new Food() { Id = 42, Name = "Kısır", StandartPortion = 100, PortionProtein = 5, PortionFat = 2, PortionCarb = 21, PortionCalorie = 130, Photo = null},
     new Food() { Id = 43, Name = "Dondurma", StandartPortion = 100, PortionProtein = 3.6, PortionFat = 7.3, PortionCarb = 20, PortionCalorie = 178, Photo = null},
     new Food() { Id = 44, Name = "Soda", StandartPortion = 100, PortionProtein = 0, PortionFat = 0, PortionCarb = 11, PortionCalorie = 45, Photo = null},
     new Food() { Id = 45, Name = "Su", StandartPortion = 100, PortionProtein = 0, PortionFat = 0, PortionCarb = 0, PortionCalorie = 0, Photo = null}
 );

            base.OnModelCreating(modelBuilder);
        }
    }
}
