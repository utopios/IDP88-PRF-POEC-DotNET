using CaisseEnregistreuse.Services;
using CaisseEnregistreuse.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICartService, SessionCartService>();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddSession();
//Enregistrer les classes

builder.Services.AddTransient<IDevice,DeviceService>();
builder.Services.AddDbContext<DataDbContext>();

//Enregister un service pour accéder au HttpContext dans les classes autre que les contrôleurs.
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
