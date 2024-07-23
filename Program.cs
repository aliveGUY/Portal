using Microsoft.EntityFrameworkCore;
using Lib.AspNetCore.ServerSentEvents;
using Microsoft.AspNetCore.Mvc;
using DotNetEnv;

using Portal.Models;
using Portal.Interfaces;
using Portal.Repository;
using Portal.Data;

Env.Load();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddRazorPages(o => {
    // this is to make demos easier
    // don't do this in production
    o.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
}).AddRazorRuntimeCompilation();

builder.Services.AddServerSentEvents();
builder.Services.AddHostedService<ServerEventsWorker>();


builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer($"{Env.GetString("CONNECTION_STRING")}");
});

builder.Services.AddScoped<IPostRepository, PostRepository>();


var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapServerSentEvents("/rn-updates");
app.MapRazorPages();

app.Run();
