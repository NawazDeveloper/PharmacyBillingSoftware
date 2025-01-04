using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PharmacyManagementAPI.Data;
using PharmacyManagementAPI.Data.PharmacyManagementAPI.Data;
using PharmacyManagementAPI.Repositories;
using PharmacyManagementAPI.Services.IService;
using PharmacyManagementAPI.Services.Service;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Configure Services
builder.Services.AddControllers();

// Add Swagger/OpenAPI if in development environment
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Pharmacy Management API",
        Version = "v1",
        Description = "API documentation for the Pharmacy Management System"
    });
});

// Configure DbContext (with SQL Server)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add CORS (if needed)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .AllowAnyOrigin();
    });
});



// Add Repository Pattern Services
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});


// Build the app
var app = builder.Build();

// Configure the middleware
if (app.Environment.IsDevelopment())
{
   

   

}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pharmacy Management API V1");
});
// Global Exception Handling Middleware (if any)
app.UseMiddleware<GlobalExceptionMiddleware>();

// Enable HTTPS Redirection
app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AllowAllOrigins");

// Enable Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();

// Map Controllers
app.MapControllers();

app.Run();
