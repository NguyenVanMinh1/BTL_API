using BLL.BusUser;
using BLL.Iterfaces;
using DAL.DALManage;
using DAL.Helper;
using DAL.Iterfaces.IManageApiRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDatabaseHelper, DatabaseHelper>();
builder.Services.AddTransient<IProductManageApi, ProductManageDAL>();
builder.Services.AddTransient<IProductManageBus, ProductAdminBus>();

builder.Services.AddTransient<IUserManageApi, CheckUserManageDAL>();
builder.Services.AddTransient<ICheckUserManageBus, CheckUserAdminBus>();
builder.Services.AddTransient<ICategoryManageApi, CategoryManageDAL>();
builder.Services.AddTransient<ICategoryManageBus, CategoryManageBus>();
builder.Services.AddTransient<IBrandManageApi, BrandManageDAL>();
builder.Services.AddTransient<IBrandManageBus, BrandManageBus>();
builder.Services.AddCors(p => p.AddPolicy("MyCors", build => { build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("MyCors");
app.MapControllers();
app.UseStaticFiles();
app.UseDirectoryBrowser();

app.Run();
