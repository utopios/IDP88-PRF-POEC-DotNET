var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Ajout du service session
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

//Utilisation du middleware session
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Ajout d'une custom route
app.MapControllerRoute("customRoute", "titi", new { controller = "Home", action = "Index" });


//Route avec deux paramètes
app.MapControllerRoute("customRouteArgs", "custom-contact/{firstName}/{lastName}", new { controller = "Contact", action = "CustomDetail" });

app.Run();
