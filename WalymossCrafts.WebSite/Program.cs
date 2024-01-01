using System.Text.Json;
using WalymossCrafts.WebSite.Models;
using WalymossCrafts.WebSite.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();
//app.MapGet("/products", (JsonFileProductService productService) =>
//{
//    var products = productService.GetProducts();
//    var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
//    return Results.Ok(json);
//});


app.Run();
