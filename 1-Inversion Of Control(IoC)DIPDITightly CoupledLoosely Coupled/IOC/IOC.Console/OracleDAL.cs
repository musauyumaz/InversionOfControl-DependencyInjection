namespace IOC.Console
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new(){Id = 1,Name = "Oracle Kalem 1", Price =100, Stock = 200},
                new(){Id = 2,Name = "Oracle Kalem 2", Price =100, Stock = 200},
                new(){Id = 3,Name = "Oracle Kalem 3", Price =100, Stock = 200},
                new(){Id = 4,Name = "Oracle Kalem 4", Price =100, Stock = 200}
            };
        }
    }
}
