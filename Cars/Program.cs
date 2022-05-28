using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cars.Data;
using Microsoft.OpenApi.Models;
using Cars.Helpers;
using Cars.Authorization;
using Cars.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CarsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarsContext") ?? throw new InvalidOperationException("Connection string 'CarsContext' not found.")));

// Add services to the container.
{
   // var services = builder.Services;

   builder.Services.AddCors();
    builder.Services.AddControllers();

    //Configure automapper with all automapper profiles from this assembly

    builder.Services.AddAutoMapper(typeof(Program));

    //Configure strongy typed settings object

    builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

    // configure DI for application services 

    builder.Services.AddScoped<IJwtUtils, JwtUtils>();
    builder.Services.AddScoped<IUserService, UserService>();
    //services.AddControllers();
}

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//migrate any database changes on startup (includes initial db creation)
/*using (var scope= app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<CarsContext>();
    dataContext.Database.Migrate();
}*/

// Configure the HTTP request pipeline.

{
    //global cors policy 
    app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

    //global error handler 

    app.UseMiddleware<ErrorHandlerMiddleware>();

    app.UseMiddleware<JwtMiddleware>();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
}

app.Run();


