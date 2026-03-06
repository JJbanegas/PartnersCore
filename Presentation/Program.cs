using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Presentation.Helpers;
using ConfigurationExtensions = Presentation.Helpers.ConfigurationExtensions;

var builder = WebApplication.CreateBuilder(args);

ConfigurationExtensions.SetConfigurationExtensions(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Partners Core API v1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Partners Core API v2");
    });
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<PartnersCoreDbContext>();
        dbContext.Database.Migrate();
    }
}

app.RegisterEndpointDefinitions();

app.UseHttpsRedirection();

app.Run();