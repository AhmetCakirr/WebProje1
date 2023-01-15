using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}");


app.Run();
