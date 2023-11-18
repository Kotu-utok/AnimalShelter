using CDA;


var builder = WebApplication.CreateBuilder(args);
string connectionString = String.Empty;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);


var app = builder.Build();

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
