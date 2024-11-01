using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LexiconIMDB.Data;
using LexiconIMDB.Services;
namespace LexiconIMDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LexiconIMDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LexiconIMDBContext") ?? throw new InvalidOperationException("Connection string 'LexiconIMDBContext' not found.")));

            builder.Services.AddScoped<IGenreSelectListService, GenreSelectListService>(); 

            //builder.Service.AddSingleton => Samma f�r hela applikationens livsl�ngd. 
            //builder.Service.AddScoped => Samma instans f�r hela v�rt request.
            //builder.Service.Transient => Ny instans s� fort n�gon beh�ver servicen. 

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
