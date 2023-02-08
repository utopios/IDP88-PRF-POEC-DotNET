using TP03.Datas;
using TP03.Models;
using TP03.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", options =>
{
    options.Cookie.Name = "CookieAuth";
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(7);
});

builder.Services.AddAuthorization(options => {
    options.AddPolicy("AdminOnly",
        policy => policy.RequireClaim("Admin"));
});

builder.Services.AddSingleton<MockDatabase>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddSession();
builder.Services.AddScoped<IRepository<Book>, BooksRepository>();
builder.Services.AddScoped<IRepository<Author>, AuthorsRepository>();
builder.Services.AddScoped<IRepository<Order>, OrdersRepository>();
builder.Services.AddScoped<IRepository<OrderItem>, OrderItemsRepository>();
builder.Services.AddScoped<IRepository<WebAppUser>, WebAppUsersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();

