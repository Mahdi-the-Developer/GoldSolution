using Gold.Infrastructure.GoldDbContext;
using Gold.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();
app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Error/404";
        await next();
    }
});
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.MapControllers();



app.Run();
