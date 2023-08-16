using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using JWT_Auth.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IStudent, StudentService>(); builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PayodaStudentContext>(

 optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection"))

);

//builder.Services.AddScoped<IStudent, StudentService>();
builder.Services.AddScoped<IUser, UserService>();


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
