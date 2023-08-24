namespace IOC.Console
{
    public class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new(){Id = 1,Name = "Kalem 1", Price =100, Stock = 200},
                new(){Id = 2,Name = "Kalem 2", Price =100, Stock = 200},
                new(){Id = 3,Name = "Kalem 3", Price =100, Stock = 200},
                new(){Id = 4,Name = "Kalem 4", Price =100, Stock = 200}
            };
        }

        public int Hesapla()
        {
            return 100;
        }
    }
}
