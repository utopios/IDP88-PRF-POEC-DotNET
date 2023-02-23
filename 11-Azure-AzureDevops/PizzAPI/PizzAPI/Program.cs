using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PizzAPI.Datas;
using PizzAPI.Helpers;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// permet de récupérer la section AppSetings du fichier appsettings.json
var appSettingsSection = builder.Configuration.GetSection(nameof(AppSettings));
// on l'enregistre dans les services
builder.Services.Configure<AppSettings>(appSettingsSection);

AppSettings appSettings = appSettingsSection.Get<AppSettings>();


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

var key = Encoding.ASCII.GetBytes(appSettings.SecretKey!);

// Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // utilisation d'une clé cryptée pour la sécurité du token
            IssuerSigningKey = new SymmetricSecurityKey(key), // clé cryptée en elle même
            ValidateLifetime = true, // vérification du temps d'expiration du Token
            ValidateAudience = true, // vérification de l'audience du token
            ValidAudience = appSettings.ValidAudience, // l'audience
            ValidateIssuer = true, // vérification du donneur du token
            ValidIssuer = appSettings.ValidIssuer, // le donneur
            ClockSkew = TimeSpan.Zero // décallage possible de l'expiration du token
        };
    });

// Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(Constants.PolicyAdmin, police =>
    {
        police.RequireClaim(ClaimTypes.Role, Constants.RoleAdmin);
    });
    options.AddPolicy(Constants.PolicyUser, police =>
    {
        police.RequireClaim(ClaimTypes.Role, Constants.RoleUser);
    });
});

// pour éviter les cycles/la redondance (un ingrédient qui a sa pizza dans le json qui a elle même son ingrédient
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = nameof(PizzAPI), Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Type = SecuritySchemeType.Http
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme
            {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
            },
            new string[] { }
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(option =>
{
    option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
