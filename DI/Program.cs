using System.Collections.Generic;
using WebApplication2.Entites;
using WebApplication2.Extentions;
using WebApplication2.Services;
using WebApplication2.Services.Interface;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();


builder.Services.AddScoped<IUserServices, UserServices>();
//--------Use Service Extention----------
builder.Services.AddAllServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.Run();

