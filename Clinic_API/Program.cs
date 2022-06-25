
using ClinicQueriesAPI.Data;
using ClinicQueriesAPI.DBContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ClinicContext>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:ClinicInfoDBConnectionString"]));

builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IQueryRepository, QueryRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


