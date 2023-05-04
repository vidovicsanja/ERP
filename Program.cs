using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Service;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ProjectConfiguration projectConfiguration = new ProjectConfiguration();
builder.Services.AddSingleton(projectConfiguration);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = false;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = projectConfiguration.Jwt.Audience,
        ValidIssuer = projectConfiguration.Jwt.Issuer,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(projectConfiguration.Jwt.Key))
    };
});


builder.Services.AddDbContext<ApplicationContext>(optionBuilder => { 
    optionBuilder.UseSqlServer("Server=LAPTOP-S8BLMRE6\\\\SQLEXPRESS;Database=PoslasticarnicaERP2;Trusted_Connection=True;");
    optionBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder => {
    builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().Build();
}));



builder.Services.AddScoped<IKorisnikService, KorisnikService>();
builder.Services.AddScoped<IKategorijaProizvodaService, KategorijaProizvodaService>();
builder.Services.AddScoped<IProizvodService, ProizvodService>();
builder.Services.AddScoped<ISastojakService, SastojakService>();
builder.Services.AddScoped<ISastojakProizvodaService, SastojakProizvodaService>();
builder.Services.AddScoped<IPorudzbinaService, PorudzbinaService>();
builder.Services.AddScoped<IStavkaPorudzbineService, StavkaPorudzbineService>();
builder.Services.AddScoped<IPlacanjeService, PlacanjeService>();
builder.Services.AddScoped<IIsporukaService, IsporukaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.UseCors("MyPolicy");

app.MapControllers();

app.Run();
