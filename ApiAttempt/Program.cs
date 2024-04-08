using FinalApp.BusinessLayer.Abstract;
using FinalApp.BusinessLayer.Concrete;
using FinalApp.DataAccessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IAboutService, IAboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IBookingService, IBookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddScoped<ICategoryService, ICategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<IContactService, IContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IDiscountService, IDiscountManager>();
builder.Services.AddScoped<IDiscountDal, EfDiscountDal>();
builder.Services.AddScoped<IFeatureService, IFeatureManager>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
builder.Services.AddScoped<IProductService, IProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
app.Run();
