using Proyecto._1erParcial.Api.Repositories;
using Proyecto._1erParcial.Api.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IProductCategoryRepository, InMemoryProductCategoryRepository>();

// Se añaden los servicios de las interfaces de los almacenamientos en memoria de los repositorios:
// Para "Apparatus".
builder.Services.AddSingleton<IApparatusRepository, InMemoryApparatusRepository>();

// Para "Reparation".
builder.Services.AddSingleton<IReparationRepository, InMemoryReparationRepository>();

// Para "User".
builder.Services.AddSingleton<IUserRepository, InMemoryUserRepository>();

// Para "Warranty".
builder.Services.AddSingleton<IWarrantyRepository, InMemoryWarrantyRepository>();

// Para "CustomerAddress".
builder.Services.AddSingleton<ICustomerAddressRepository, InMemoryCustomerAddressRepository>();

// Para "Customer".
builder.Services.AddSingleton<ICustomerRepository, InMemoryCustomerRepository>();

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