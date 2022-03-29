using theAPI.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            //This was done for testing purposes, should switch to only the
            //web origin in case anyone buys this project.
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();

