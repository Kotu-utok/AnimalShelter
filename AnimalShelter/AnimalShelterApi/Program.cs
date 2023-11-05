var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting(); // This should be before UseAuthorization and endpoint mapping

app.UseAuthorization();

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
