using CrudFile.AppServices.Mappers;
using CrudFile.Core;
using CrudFile.EntityFrameworkCore;
using CrudFile.EntityFrameworkCore.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// For Entity Framework
builder.Services.AddDbContext<CrudFileDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("Default")));

//Serviices Trasient Repository
builder.Services.AddTransient<IRepository<int,ElementFile>,Repository<int,ElementFile>>();

//Mapper
builder.Services.AddAutoMapper(typeof(MapperFile));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
IWebHostEnvironment environment = app.Environment;
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
