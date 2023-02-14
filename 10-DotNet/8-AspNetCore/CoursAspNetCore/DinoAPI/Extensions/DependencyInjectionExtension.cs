using DinoAPI.Models;
using DinoAPI.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using DinoAPI.Datas;
using DinoAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DinoAPI.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void InjectDependancies(this WebApplicationBuilder builder)
        {
            builder.AddAuth();

            builder.AddCorsPolicy();

            builder.AddDatabase();

            builder.AddRepositories();

            builder.AddSwagger();

            builder.Services.AddControllers();
           
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            //builder.Services.AddSingleton<FakeDB>();
            builder.Services.AddScoped<IRepository<Dinosaur>, DinoRepository>();
        }

        private static void AddDatabase(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }

        private static void AddCorsPolicy( this WebApplicationBuilder builder)
        {
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
        }

        private static void AddAuth(this WebApplicationBuilder builder)
        {
            // permet de récupérer la section AppSetings du fichier appsettings.json
            var appSettingsSection = builder.Configuration.GetSection(nameof(AppSettings));
            // on l'enregistre dans les services
            builder.Services.Configure<AppSettings>(appSettingsSection);

            AppSettings appSettings = appSettingsSection.Get<AppSettings>();

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
                    police.RequireClaim("EstUnDresseurDeDino", "true");
                });
            });
        }

        private static void AddSwagger(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DinoApi", Version = "v1" });
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
        }
    }
}
