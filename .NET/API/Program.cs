using Tickett.Data;
using Tickett.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;


var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:5173");
                      });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
// }

// app.UseHttpsRedirection();
// var connectionString = builder.Configuration.GetConnectionString("ServerDB");
var connectionString = builder.Configuration.GetConnectionString("ServerDB");

// builder.Services.AddScoped<IObraService, ObraService>();
builder.Services.AddScoped<IObraService, ObraService>();
builder.Services.AddScoped<IObraRepository, ObraEFRepository>();

// builder.Services.AddScoped<IIngredienteService, IngredienteService>();
// builder.Services.AddScoped<IIngredientesRepository, IngredienteEFRepository>();

// builder.Services.AddDbContext<ObraContext>(options =>
//     options.UseSqlServer(connectionString)
//     .LogTo(Console.WriteLine, LogLevel.Information));
builder.Services.AddDbContext<ObraContext>(Options =>
        Options.UseSqlServer(connectionString)
        .LogTo(Console.WriteLine,LogLevel.Information));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseCors(MyAllowSpecificOrigins);


app.UseAuthorization();
app.MapControllers();
app.Run();