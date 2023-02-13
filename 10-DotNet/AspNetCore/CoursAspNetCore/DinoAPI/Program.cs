using DinoAPI.Datas;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<FakeDB>();

// ajout de policy pour les cors
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("allConnections", options=> {
//        options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//    });
//    options.AddPolicy("angular", options => {
//        options.WithOrigins("http://angularaddress:angularport").AllowAnyMethod().AllowAnyHeader();
//    });
//});

var key = Encoding.ASCII.GetBytes("cl� tr�s s�curis�e: Denver le dernier dinosaur !");

// Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken= true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // utilisation d'une cl� crypt�e pour la s�curit� du token
            IssuerSigningKey = new SymmetricSecurityKey(key), // cl� crypt�e en elle m�me
            ValidateLifetime = true, // v�rification du temps d'expiration du Token
            ValidateAudience = true, // v�rification de l'audience du token
            ValidAudience = "dinocorp", // l'audience
            ValidateIssuer = true, // v�rification du donneur du token
            ValidIssuer = "dinocorp", // le donneur
            ClockSkew = TimeSpan.Zero // d�callage possible de l'expiration du token
        };
    });

// Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "Admin");
    });
    options.AddPolicy("UserPolicy", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "User");
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// c'est ici que l'on dit que l'on va utiliser les cors sur l'application
// on laisse vide quand on utilise les policy
// il reste possible de pr�ciser un policy g�n�rale qui s'appliquera � toute l'application
app.UseCors(option =>
{
    option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
