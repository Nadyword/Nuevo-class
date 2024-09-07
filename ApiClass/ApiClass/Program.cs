using ApiClass.Interfaces;
using ApiClass.Repositories;
using ApiClass.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiInterna", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
        .WithMethods(["GET"]).
        AllowAnyHeader();
        //builder.SetIsOriginAllowed(origen => new Uri(origen).Host == "localhost");
    });
});

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();



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