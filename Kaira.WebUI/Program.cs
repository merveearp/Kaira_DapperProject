using Kaira.WebUI.Context;
using Kaira.WebUI.Extensions;
using Kaira.WebUI.Models;
using Kaira.WebUI.Services.AIServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRepository();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddControllersWithViews();


builder.Services.Configure<OpenAISettings>
    (
    builder.Configuration.GetSection("OpenAI")
    );
builder.Services.AddHttpClient<IAIStyleService, AIStyleService>();
builder.Services.AddSession();



var app = builder.Build();
app.UseSession();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();


app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
