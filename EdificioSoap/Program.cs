using EdificioSoap.ServicesContracts;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IEdificioService, EdificioSoap.ServicesContracts.EdificioService>();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSoapEndpoint<IEdificioService>("/EdificioService.asmx", new SoapEncoderOptions());
app.UseAuthorization();
app.MapControllers();
app.Run();