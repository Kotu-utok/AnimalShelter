using AnimalShelterApi.MappingProfile;
using Azure.Identity;
using CDA;
using DAL;
using Microsoft.Extensions.Configuration;
using System.Reflection;

string connectionString = String.Empty;
var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), true);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
builder.Services.AddAutoMapper(typeof(AnimalMappingProfile));


RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);



var app = builder.Build();
if (app.Environment.EnvironmentName == "Local")
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    app.UseDeveloperExceptionPage();
}
else if( app.Environment.IsDevelopment())
{
    builder.Configuration.AddAzureKeyVault(new Uri(builder.Configuration["KEY_VAULT_URI"]), new DefaultAzureCredential());
    connectionString = builder.Configuration["ConnectionString"];
}
RegisterDALServices.ManageDepenciesDAL(builder.Services, connectionString);
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseRouting();
app.Use(async (context, next) =>
{
    if (context.Request.Path.Value == "/")
    {
        context.Response.Redirect("/swagger", permanent: false);
    }
    else
    {
        await next();
    }
});

app.MapControllers();


app.Run();
