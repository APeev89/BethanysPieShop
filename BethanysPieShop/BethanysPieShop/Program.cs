using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPieRepository, MockPieRepository>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddControllersWithViews();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();