using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="c#"},
                new Category(){KategoriAdi="Asp.net MVC"},
                new Category(){KategoriAdi="Asp.net WebForm"},
                new Category(){KategoriAdi="Windows Form"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-30),
                    Anasayfa=false,Onay=false,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="2.jpg",CategoryId=1},
                new Blog(){Baslik="c# Cenetig Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=false,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=2},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-20),
                    Anasayfa=false,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-50),
                    Anasayfa=true,Onay=false,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="2.jpg",CategoryId=3},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-15),
                    Anasayfa=false,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=3},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="2.jpg",CategoryId=3},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=4},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-5),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=4},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=4},
                new Blog(){Baslik="c# delegates Hakkında",Aciklama="c# delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),
                    Anasayfa=true,Onay=true,Icerik="c# delegates Hakkında c# delegates Hakkında",Resim="1.jpg",CategoryId=4}
            };

            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}