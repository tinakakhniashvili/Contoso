

using fateraki2._0.Models;
using fateraki2._0.Services;

using System.Text.Json;
using Microsoft.AspNetCore.Builder;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddRazorPages();

        builder.Services.AddTransient<JsonFileProductService>();

        builder.Services.AddServerSideBlazor();

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

        app.UseRouting();


        app.UseAuthorization();
        app.MapControllers();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapControllers();
          //  endpoints.MapBlazorHub();
        });

        app.MapBlazorHub();

        app.MapRazorPages();

        app.Run();
    }
}