
namespace TestApi.Services
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        public DateService()
        {
            Console.WriteLine("DateService constructor'ına girdi.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
     }
}
