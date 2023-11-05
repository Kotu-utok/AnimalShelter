using CDA;
using DAL;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);
string connectionString = String.Empty;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);

if(builder.Environment.EnvironmentName == "Local")
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}
else
{
    string keyVaultUri = builder.Configuration["KEY_VAULT_URI"];
    if(!string.IsNullOrEmpty(keyVaultUri))
    {
        builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUri), new DefaultAzureCredential());
    }
    else
    {
        throw new InvalidOperationException("Key Vault URI must be set in the environment variables.");
    }
    connectionString = builder.Configuration["ConnectionString"];
}

RegisterDALServices.ManageDepenciesDAL(builder.Services, connectionString);

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
