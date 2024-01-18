using ControleBoleto.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSwaggerConfiguration();

builder.Services.AddApiConfig(builder.Configuration);

builder.Services.RegisterServices();

/*builder.Services.AddJwtConfiguration(builder.Configuration);*/

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerConfiguration();

app.UseApiConfiguration(app.Environment);

app.Run();
