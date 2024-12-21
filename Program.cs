namespace File_IO__Json_Serialize_DeSerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Test";
            product.CostPrice = 10;
            product.SalePrice = 11;
            //Product product2 = new Product();
            //product2.Name = "Test2";
            //product2.CostPrice = 20;
            //product2.SalePrice = 0;
            ProductService.Create(product);
            //ProductService.Create(product2);
           // ProductService.Delete(0);
        }
    }
}
