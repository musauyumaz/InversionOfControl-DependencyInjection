namespace IOC.Console
{
    public class DALFactory
    {
        public static DAL GetDAL()
        {
            return new();
        }
    }
}
