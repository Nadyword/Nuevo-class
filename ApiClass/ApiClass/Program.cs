var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiInterna", builder =>
    {
        builder.WithOrigins("http://localhost:3001").WithMethods(["GET"]).AllowAnyHeader();
        //builder.SetIsOriginAllowed(origen => new Uri(origen).Host == "localhost");
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ApiInterna");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();