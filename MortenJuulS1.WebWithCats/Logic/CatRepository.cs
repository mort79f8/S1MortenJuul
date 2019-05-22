using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortenJuulS1.WebWithCats.Logic
{
    public class CatRepository
    {
        public List<Cat> GetCatsFromFile()
        {
            List<Cat> cats = new List<Cat>();
            Cat cat1 = new Cat
            {
                Header = "Fluffy",
                Description = "Fluffy is a red cat",
                AltText = "Pictured of Fluffy the red cat",
                UrlToPicture = "img/fluffy.jpg"
            };

            cats.Add(cat1);
            cats.Add(new Cat
            {
                Header = "bunny",
                Description = "bunny is a grey cat",
                AltText = "Pictured of bunny the grey cat",
                UrlToPicture = "img/bunny.jpg"
            });
            cats.Add(new Cat
            {
                Header = "Mr.Biggles",
                Description = "Mr.Biggles is a black cat",
                AltText = "Pictured of Mr.Biggles the black cat",
                UrlToPicture = "img/mrbiggles.jpg"
            });
            return cats;
        }

    }
}
