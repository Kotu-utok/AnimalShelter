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
app.MapControllers();

app.Run();
