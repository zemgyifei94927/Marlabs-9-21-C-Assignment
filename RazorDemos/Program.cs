namespace RazorDemos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.MapControllers();
            app.UseStaticFiles();
            app.Run();
        }
    }
}