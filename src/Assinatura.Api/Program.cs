using WkHtmlToPdfDotNet.Contracts;
using WkHtmlToPdfDotNet;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

builder.Services.AddCors(p => p.AddPolicy("CORS", builder =>
 {
     builder
     .WithOrigins("*")
     .AllowAnyMethod()
     .AllowAnyHeader();
 }));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("CORS");
app.UseAuthorization();

app.MapControllers();

app.Run();
