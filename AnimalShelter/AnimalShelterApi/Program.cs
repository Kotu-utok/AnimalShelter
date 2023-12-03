using AnimalShelterApi.MappingProfile;
using CDA;
using DAL;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
string connectionString = String.Empty;
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

RegisterDALServices.ManageDepenciesDAL(builder.Services, builder.Configuration.GetConnectionString("DefaultConnection"));
RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
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
