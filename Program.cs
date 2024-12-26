using Microsoft.EntityFrameworkCore;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;
using ProjetCsharpExamMbathio.Services.Implementations;

public partial class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure the database connection string
        string connectionString = builder.Configuration.GetConnectionString("MysqlConnection")!;

        // Configure the database context
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 33)))); // Ensure consistent MySQL version

        // Register services
        builder.Services.AddScoped<IClientService, ClientService>();
        builder.Services.AddScoped<ICommandeService, CommandeService>();
        builder.Services.AddScoped<IProduitService, ProduitService>();
        builder.Services.AddScoped<ILivreurService, LivreurService>();
        builder.Services.AddScoped<ILivraisonService, LivraisonService>();
        builder.Services.AddScoped<IPaiementService, PaiementService>();

        // Add services to the container
        builder.Services.AddControllersWithViews();

        var app = builder.Build(); // Ensure app is declared after service registration

        // Add development-specific error handling
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Use the developer exception page for error handling
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
