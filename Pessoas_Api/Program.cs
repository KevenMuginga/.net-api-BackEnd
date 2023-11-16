using Microsoft.AspNetCore.Cors.Infrastructure;
using Pessoas_Api.Configuration;
using Pessoas_Manager.mapping;

var builder = WebApplication.CreateBuilder(args);
var CorsPolicy = "_corsPolicy";

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CorsPolicy,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
        });
});

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(PessoasMappingProfile));
//builder.Services.AddMapperConnfiguration()
builder.Services.AddDataBaseConfiguration(builder.Configuration);
builder.Services.AddDepedencyInjectionConfig();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(CorsPolicy);

app.MapControllers();

app.Run();
