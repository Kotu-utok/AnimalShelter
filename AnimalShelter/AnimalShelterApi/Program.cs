using CDA;


var builder = WebApplication.CreateBuilder(args);
string connectionString = String.Empty;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RegisterCDAServices.RegisterTypeServiceCollectionExtention(builder.Services);


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty; // To serve the Swagger UI at the app's root (https://<your-app-name>.azurewebsites.net/), set RoutePrefix to an empty string.
});
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers(); 


app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", context => {
        context.Response.Redirect("/swagger");
        return Task.CompletedTask;
    });
    endpoints.MapControllers(); // Maps routes to controllers
});
app.Run();
