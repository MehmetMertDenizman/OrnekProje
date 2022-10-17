namespace OrnekProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            Startup startup = new Startup();


             
            app.MapGet("/", () => "Hello World!");

            app.Run();



        }
    }
}