using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//E�er CarManager i�erisinde data tutuluyorsa kullan�lmaml� bu yap�.
//herkes i�in ayn� referans� tutaca�� i�in insanlar�n datalar� kar���r.
builder.Services.AddSingleton<ICarService, CarManager>();

builder.Services.AddSingleton<ICarDal , EfCarDal>();

builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();   


//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name:"BATUG", policy =>
    {
        policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    });
});
//builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AutofacBusinessModule()); });
//Yukar�da yapt���m�z singleton i�leminin yerine olu�turd�umuz autofacBusinessModule kullan�lmas�n� s�yledik.
//.net alt pa�s�nda olan IOC kullanma fabrika olarak autofac kullan.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("BATUG");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
