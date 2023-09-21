using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Bir iş sınıfı başka sınıfları new lemez 
    //Dependecy Injection kullan

    
    public interface ICarService
    {   
        //Data döndürdükleri için IDataResult yapısına ihtiyaç duyduk.Hem data hem mesaj ve işlem bilgisine sahip.
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBranID(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetDetails();
        IDataResult<List<Car>> GetByDailyPrice(decimal min , decimal max);
        IDataResult<List<Color>>GetColors();
        //Data olmayanları IResult olarak bıraktık çünkü onlar bir data döndürmüyorlar.Sadece CRUD operasyonlarını yapıyorlar.
        IResult Add(Car car);
        
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<Car> GetById(int id);
        
    }
}
