using dpd_api.Domain.Requests;
using dpd_api.Domain.Responses;
using dpd_api.Services.ClientServices;

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

//builder.Services.AddTransient<DpdClient<ServicesRequest, ServicesResponse>>();
builder.Services.AddTransient(typeof(IDpdClient), typeof(DpdClient));
builder.Services.AddTransient(typeof(IDpdClientBase<ServicesRequest, ServicesResponse>), typeof(DpdClientBase<ServicesRequest, ServicesResponse>));
builder.Services.AddTransient(typeof(IDpdClientBase<CalculationRequest, CalculationResponse>), typeof(DpdClientBase<CalculationRequest, CalculationResponse>));
builder.Services.AddTransient(typeof(IDpdClientBase<ShipmentRequest, CreateShipmentResponse>), typeof(DpdClientBase<ShipmentRequest, CreateShipmentResponse>));
builder.Services.AddTransient(typeof(IDpdClientBase<PrintRequest, PrintResponse>), typeof(DpdClientBase<PrintRequest, PrintResponse>));
builder.Services.AddTransient(typeof(IDpdClientBase<PickupRequest, PickupResponse>), typeof(DpdClientBase<PickupRequest, PickupResponse>));

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
