using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
//foreach (var car in carmanager.getall())
//{
//    console.writeline(car.brandname);


//}

foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.ModelYear);


}

foreach (var car in carManager.GetDetails())
{
    Console.WriteLine(car.DailyPrice + "/" + car.ColorName ); //hata var istenileni vermiyor. 
}

