using SuministroProvisiones.INFRAESTRUCTURE.Data.Context;
using Microsoft.EntityFrameworkCore;
using SuministroProvisiones.Domain.IRepositories;
using SuministroProvisiones.Infrastructure.Data.Repositories;
using SuministroProvisiones.Domain.Services.IServices;
using SuministroProvisiones.Domain.Services;
using SuministroProvisiones.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region [Connection DataBase]
builder.Services.AddDbContext<ApplicationDbContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty);
});
#endregion

#region [DI Container]
builder.Services.AddScoped<ISolicitudSuministroResponseRepository, SolicitudSuministroResponseRepository>();
builder.Services.AddScoped<ISolicitudSuministroRepository, SolicitudSuministroRepository>();
builder.Services.AddScoped<ISolicitudSuministroService, SolicitudSuministroService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
#endregion

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
