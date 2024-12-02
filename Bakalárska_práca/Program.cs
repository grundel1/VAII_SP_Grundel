using Bakalárska_práca.Components;
using Bakalárska_práca.Model;
using Microsoft.EntityFrameworkCore;

namespace Bakalárska_práca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            var optionsDb = new DbContextOptionsBuilder<ClinicContext>()
                .UseSqlServer(builder.Configuration.GetConnectionString("DentistSystem"))
                .Options;

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<ClinicContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DentistSystem")));


            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            using ClinicContext context = new ClinicContext(optionsDb);

            Dentist dentist = new Dentist()
            {
                Address = "Palackého 14",
                City = "Trenčín",
                Name = "Sam",
                Surname = "Gründel",
            };
            context.Add(dentist);
            context.SaveChanges();

            app.Run();

        }
    }
}

