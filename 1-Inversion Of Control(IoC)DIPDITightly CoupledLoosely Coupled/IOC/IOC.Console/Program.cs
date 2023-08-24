using IOC.Console;

BL bl = new(new OracleDAL());

bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
});