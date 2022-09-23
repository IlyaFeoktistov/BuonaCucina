using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BuonaCucina
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();
            builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Recipes}/{action=Index}/{id?}");

            app.Run();
        }
    }
}