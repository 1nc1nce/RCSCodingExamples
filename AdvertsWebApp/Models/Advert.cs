using System;
namespace AdvertsWebApp.Models
{
    public class Advert
    {
        public Advert()
        {
        }
        public int AdvertID { get; set; }
        public double Price { get; set; } //Mainīgajiemm nepieciešams norādīt properties ar get, set
        public string Name { get; set; }
        public string AdvertText { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
