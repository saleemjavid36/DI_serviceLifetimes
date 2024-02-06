using DependencyInjection;
using DependencyInjection.Interfaces;
using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IStudentRepo,StudentRepo>();

// Example for Service lifetimes
builder.Services.AddSingleton<ISingleton, Singleton>();
builder.Services.AddTransient<ITransient, Transient>();
builder.Services.AddScoped<IScoped, Scopped>();
// service life time ended


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
