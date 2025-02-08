using GuitarStore.Portal.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

new RootBootstrapper().BootstrapperRegisterServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
            options.SwaggerEndpoint("/openapi/v1.json", "GuitarStore Api"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
