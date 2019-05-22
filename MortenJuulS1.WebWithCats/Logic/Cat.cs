using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortenJuulS1.WebWithCats.Logic
{
    public class Cat
    {
        private string urlToPicture;
        private string header;
        private string description;
        private string altText;

        public string UrlToPicture { get => urlToPicture; set => urlToPicture = value; }
        public string Header { get => header; set => header = value; }
        public string Description { get => description; set => description = value; }
        public string AltText { get => altText; set => altText = value; }
    }
}
