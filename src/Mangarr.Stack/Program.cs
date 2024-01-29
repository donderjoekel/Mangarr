using Mangarr.Stack.AniList;
using Mangarr.Stack.Archival;
using Mangarr.Stack.Caching;
using Mangarr.Stack.Comic;
using Mangarr.Stack.Conversion;
using Mangarr.Stack.Cover;
using Mangarr.Stack.Database;
using Mangarr.Stack.Downloading;
using Mangarr.Stack.Exporting;
using Mangarr.Stack.Initialization;
using Mangarr.Stack.Jobs;
using Mangarr.Stack.Library;
using Mangarr.Stack.Logging;
using Mangarr.Stack.Manga;
using Mangarr.Stack.Notifications;
using Mangarr.Stack.Settings;
using Mangarr.Stack.Sources;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));

builder.AddMangarrAniList();
builder.AddMangarrArchiving();
builder.AddMangarrCaching();
builder.AddMangarrComic();
builder.AddMangarrConversion();
builder.AddMangarrCover();
builder.AddMangarrDatabase();
builder.AddMangarrDownloading();
builder.AddMangarrExporting();
builder.AddMangarrInitialization();
builder.AddMangarrJobs();
builder.AddMangarrLibraryApi();
builder.AddMangarrLogging();
builder.AddMangarrMangaApi();
builder.AddMangarrNotifications();
builder.AddMangarrSettings();
builder.AddMangarrSources();

builder.Services.AddHttpClient();

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

IOrderedEnumerable<IInitializable> initializables =
    app.Services.GetRequiredService<IEnumerable<IInitializable>>().OrderBy(x => x.Order);

foreach (IInitializable initializable in initializables)
{
    await initializable.Initialize();
}

app.Run();
