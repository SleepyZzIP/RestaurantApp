using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sit 1/1");
            Console.WriteLine("week 2");

            List<Restaurant> list = new List<Restaurant>
            {
               new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
               new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
               new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
               Restaurant.Show(List<Restaurant> )
            };
            
        }
    }
    
    class Restaurant
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Point { get; set; }

    public Restaurant(int id,string name,string type,double point) 
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Point = point;
        }

        public void Show(string text)
        {
            Console.WriteLine(text);
        }
    }
}
