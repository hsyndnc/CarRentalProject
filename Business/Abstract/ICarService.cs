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
        List<Car> GetAll();
        List<Car> GetCarsByBranID(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        
        void Delete(Car car);
        void Update(Car car);
        public List<CarDetailDto> GetDetails();
    }
}
