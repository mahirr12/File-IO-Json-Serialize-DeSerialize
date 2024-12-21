using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace File_IO__Json_Serialize_DeSerialize
{
    //ProductService class methods :
    public static class ProductService
    {

        //void Create(Product product) - example.txt' e product'i yazdirir. (Json formatda)
        public static void Create(Product product)
        {
            if (!File.Exists(@"C:\Users\Admin\Desktop\example.txt"))
            {
                File.Create(@"C:\Users\Admin\Desktop\example.txt");
            }
            var productJson = JsonSerializer.Serialize(product);
            using StreamWriter sw = new StreamWriter("C:\\Users\\Admin\\Desktop\\example.txt", true);
            sw.WriteLine(productJson);
        }

        //Product Get(int id) - verilmis id'li Product'i qaytarir.
        public static Product Get(int id)
        {
            List<Product> products = GetAll();
            return products.Find(x => x.Id == id);
        }
        //Void Delete(int id) - verilmis id`li Product`i text'den silir
        public static void Delete(int id)
        {
            List<Product> products = GetAll();
            Product product = products.Find(x => x.Id == id);
            products.Remove(product);
            //File.Create(@"C:\Users\Admin\Desktop\example.txt");   
            foreach (var pr in products)
            {
                var productJson = JsonSerializer.Serialize(pr);
                using StreamWriter sw = new StreamWriter("C:\\Users\\Admin\\Desktop\\example.txt", true);
                sw.WriteLine(productJson);
            }

        }
        //List<Product> Getall() - butun Product'lari qaytarir
        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            var content = File.ReadAllLines("C:\\Users\\Admin\\Desktop\\example.txt");
            foreach (var line in content)
            {
                Product product = new Product();
                product = JsonSerializer.Deserialize<Product>(line);
                products.Add(product);
            }
            return products;
        }

    }
}
