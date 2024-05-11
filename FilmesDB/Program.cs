using FilmesDB.Aplicacao.Servicos;
using FilmesDB.Dominio.Entidades;
using FilmesDB.Infra.Contexto;
using FilmesDB.Infra.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var conectionString = builder.Configuration.GetConnectionString("DeafaultConnection");

builder.Services.AddDbContext<DbContexto>(options =>
    {
        options.UseMySql(conectionString,ServerVersion.AutoDetect(conectionString));



    }, ServiceLifetime.Transient
    );

// Add services to the container.
builder.Services.AddScoped < IServico<Filme> , FilmeServico>();
builder.Services.AddScoped <IServico<Ator>,AtorServico>();
builder.Services.AddScoped<IServico <Serie>, SerieServico>();

builder.Services.AddScoped<IRepositorio<Filme>, FilmeRepositorio>();
builder.Services.AddScoped<IRepositorio<Ator>, AtorRepositorio>();
builder.Services.AddScoped<IRepositorio<Serie>, SerieRepositorio>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
