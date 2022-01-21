using CrudPessoaFisicaApi.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(c => c.AddPolicy("PoliticaDeAcesso", builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));

//Aqui eu configuro a conex�o com o Sql Server
string sqlServer = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<ApiContext>(options =>
{
    options.UseSqlServer(sqlServer);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
