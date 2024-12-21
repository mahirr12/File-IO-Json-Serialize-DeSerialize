using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace File_IO__Json_Serialize_DeSerialize
{
    //    Product Class olur:
    //Id - oz-ozune artir
    //Name
    //CostPrice
    //SalePrice - CostPriceden asagi ola bilmez
    public class Product
    {
        private static int _count = 0;
        private decimal _salePrice;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice
        {
            get => _count; 
            set
            {
                if (value >= CostPrice)
                {
                    _salePrice = value;
                    Console.WriteLine("yazdi");
                }
                else
                {
                    _salePrice=CostPrice;
                    Console.WriteLine("SalePrice cant be below CostPrice");
                }
            }
        }

        public Product()
        {
            Id = ++_count;
        }

        

    }
}
