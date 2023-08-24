namespace IOC.Console
{
    public class BL
    {
        private readonly DAL _dal;
        public BL()
        {
            _dal = DALFactory.GetDAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
