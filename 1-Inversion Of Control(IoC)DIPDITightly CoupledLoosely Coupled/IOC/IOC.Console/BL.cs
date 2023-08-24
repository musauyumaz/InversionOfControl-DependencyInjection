namespace IOC.Console
{
    public class BL
    {
        private readonly IDAL _dal;
        public BL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
