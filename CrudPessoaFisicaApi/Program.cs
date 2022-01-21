using CrudPessoaFisicaApi.Application;
using CrudPessoaFisicaApi.Application.IApplication;
using CrudPessoaFisicaApi.Data.Context;
using CrudPessoaFisicaApi.Data.IRepository;
using CrudPessoaFisicaApi.Data.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(c => c.AddPolicy("PoliticaDeAcesso", builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));

//Aqui eu configuro a conexão com o Sql Server
string sqlServer = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<ApiContext>(options =>
{
    options.UseSqlServer(sqlServer);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPessoaFisicaApplication, PessoaFisicaApplication>();
builder.Services.AddScoped<IPessoaFisicaRepository, PessoaFisicaRepository>();


var app = builder.Build();


app.UseCors("PoliticaDeAcesso");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
