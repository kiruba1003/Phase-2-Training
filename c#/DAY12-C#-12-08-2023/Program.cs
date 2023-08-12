using Microsoft.EntityFrameworkCore;
using StudentDetails.Context;
using StudentDetails.Controllers;
using StudentDetails.Services;
using StudentDetails.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adding Dbcontext and pulling connection string - configuring
builder.Services.AddDbContext<StudentContext>(
    optionsAction:options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLServerConnection")
        ));
//adding services
builder.Services.AddScoped<IStudent, StudentService>();

//combine all services and build the app
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
