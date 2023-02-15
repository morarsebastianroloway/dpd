using dpd_api;
using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddTransient(typeof(IDpdClient<ServicesRequest, ServicesResponse>), typeof(DpdClient<ServicesRequest, ServicesResponse>));
builder.Services.AddTransient(typeof(IDpdClient<CalculationRequest, CalculationResponse>), typeof(DpdClient<CalculationRequest, CalculationResponse>));
builder.Services.AddTransient(typeof(IDpdClient<ShipmentRequest, CreateShipmentResponse>), typeof(DpdClient<ShipmentRequest, CreateShipmentResponse>));
builder.Services.AddTransient(typeof(IDpdClient<PrintRequest, PrintResponse>), typeof(DpdClient<PrintRequest, PrintResponse>));
builder.Services.AddTransient(typeof(IDpdClient<PickupRequest, PickupResponse>), typeof(DpdClient<PickupRequest, PickupResponse>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
