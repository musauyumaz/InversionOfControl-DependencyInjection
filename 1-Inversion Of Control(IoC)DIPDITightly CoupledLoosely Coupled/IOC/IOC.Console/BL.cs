namespace IOC.Console
{
    public class BL
    {
        private readonly DAL _dal;
        public BL()
        {
            _dal = new DAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
