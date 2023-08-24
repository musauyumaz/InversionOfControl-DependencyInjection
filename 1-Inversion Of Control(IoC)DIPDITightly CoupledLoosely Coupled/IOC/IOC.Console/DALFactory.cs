namespace IOC.Console
{
    public class DALFactory
    {
        public static IDAL GetDAL()
        {
            return new DAL();
        }
    }
}
