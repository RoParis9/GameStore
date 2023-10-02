using GameStore.API.Data;
using GameStore.API.Mapping;
using GameStore.API.Repository;
using GameStore.API.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database
builder.Services.AddDbContext<DataContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//DataContext
builder.Services.AddScoped<DbContext, DataContext>();

//Repositories
builder.Services.AddScoped<IGameRepository, GameRepository>();

//Services
builder.Services.AddScoped<IGameService, GameService>();

//Automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Cors
builder.Services.AddCors(options => options.AddPolicy(name: "NgOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:5288").AllowAnyMethod().AllowAnyHeader();
    }
));

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
