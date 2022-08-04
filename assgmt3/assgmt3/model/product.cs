using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgmt3.model
{
    internal class product
    {
        public int number { get; set; }
        public int Id { get; set; }
        public int coast { get; set; }
        public int price { get; set; }
        public string date { get; set; }
        public string name { get; set; }
        public Boolean is_available { get; set; }
        static List<product> products = new List<product>();
        public void save()
        {
            products.Add(this);
            Console.WriteLine("saved to data base successfully");
        }
        public static List<product> GetProducts() { return products; }

    }
}
