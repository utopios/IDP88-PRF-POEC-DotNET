using DinoAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.InjectDependancies();

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
// il reste possible de préciser un policy générale qui s'appliquera à toute l'application
app.UseCors(option =>
{
    option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

// ne pas oublier d'ajouter L'authentication AVANT l'authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
