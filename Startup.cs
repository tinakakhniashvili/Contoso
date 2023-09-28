using System;
using System.Text.Json;

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}
	//This method gets called by the runtime. Use this method to add services to
	public IConfiguration Configuration { get; }

	public void ConfigureServices(IserviceCollection services)
	{
		services.AddRazorPages();
		services.AddServerSideBlazor();
		services.AddControllers();
		services.AddTrasiet<JsonFileProductService>();
	}
	//This method gets called by the runtime. Use this method to configure the HT
	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
		}
		else
		{
			app.UseExceptionHandler("/Error");
		}
	}



     
}
