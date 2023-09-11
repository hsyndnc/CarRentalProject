using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.brandname);


//}

foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.ModelYear);


}


var result = carManager.GetDetails();
if (result.Success==true)
{
foreach (var car in result.Data )
    {
        Console.WriteLine(car.DailyPrice + "/" + car.ColorName);

    }


}
   

