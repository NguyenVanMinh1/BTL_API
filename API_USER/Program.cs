using BLL.BusUser;
using BLL.Iterfaces;
using DAL.DALUser;
using DAL.Helper;
using DAL.Iterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IProductRepository, ProductUserRepository>();
builder.Services.AddTransient<IProductBus, ProductBus>();
builder.Services.AddTransient<IBrandRepository, BrandUserRepository>();
builder.Services.AddTransient<IBrandBus, BrandBus>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICategoryBus, CategoryBus>();
builder.Services.AddTransient<ISlideRepository, SlideRepository>();
builder.Services.AddTransient<ISlideBus, SlideBus>();
builder.Services.AddTransient<IOrderRepository, OrderUserRepository>();
builder.Services.AddTransient<IOrderBus, OderBus>();
builder.Services.AddCors(p => p.AddPolicy("MyCors", build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("MyCors");
app.MapControllers();
app.UseStaticFiles();
app.UseDirectoryBrowser();

app.Run();
