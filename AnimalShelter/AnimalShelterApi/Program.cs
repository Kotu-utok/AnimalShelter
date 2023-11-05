using CDA;
using DAL;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
string connectionString = String.Empty;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);

//if(builder.Environment.EnvironmentName == "Local")
//{
//    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//}
//else
//{
//    string keyVaultUri = builder.Configuration["KEY_VAULT_URI"];
//    if(!string.IsNullOrEmpty(keyVaultUri))
//    {
//        builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUri), new DefaultAzureCredential());
//    }
//    else
//    {
//        throw new InvalidOperationException("Key Vault URI must be set in the environment variables.");
//    }
//    connectionString = builder.Configuration["ConnectionString"];
//}

//RegisterDALServices.ManageDepenciesDAL(builder.Services, connectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    options.RoutePrefix = string.Empty; // This will serve the Swagger UI at the app's root URL
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Maps routes to controllers
});
app.Run();
