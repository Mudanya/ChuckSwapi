using ChuckSwapi.Extensions;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region
builder.Services.ConfigureContext(builder.Configuration);
builder.Services.ConfigureCors();
builder.Services.ConfigureCategoryService();
builder.Services.ConfigurePeopleService();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigurePeopleEndPoint(builder.Configuration);
builder.Services.ConfigureCategoryEndPoint(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Use(async (context, next) =>

{

    await next();

    if (context.Response.StatusCode == 404 && !System.IO.Path.HasExtension(context.Request.Path.Value))

    {

        context.Request.Path = "/index.html";

        await next();

    }

});
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseForwardedHeaders(
    new ForwardedHeadersOptions
    { ForwardedHeaders = ForwardedHeaders.All }
    );
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
