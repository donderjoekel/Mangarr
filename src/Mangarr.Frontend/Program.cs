using Mangarr.Frontend.Api;
using Mangarr.Frontend.Configuration;
using Microsoft.Extensions.Options;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<BackendOptions>(builder.Configuration.GetSection(BackendOptions.SECTION));

builder.Services.AddHttpClient();
builder.Services.AddHttpClient("backend",
    (provider, client) =>
    {
        BackendOptions backendOptions = provider.GetRequiredService<IOptions<BackendOptions>>().Value;
        client.BaseAddress = new Uri(backendOptions.Host);
    });

builder.Services.AddSingleton<BackendHttpClient>();
builder.Services.AddSingleton<BackendApi>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

WebApplication app = builder.Build();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
