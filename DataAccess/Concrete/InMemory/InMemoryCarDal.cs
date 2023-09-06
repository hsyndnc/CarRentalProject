using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car { Id = 1,BrandId = 1 , ColorId=1, ModelYear=2023,BrandName="Audi",DailyPrice=2000, Description="A6" },
            //    new Car { Id = 2,BrandId = 1 , ColorId=2, ModelYear=2022,BrandName="Audi",DailyPrice=1800, Description="A3" },
            //    new Car { Id = 3,BrandId = 2 , ColorId=3, ModelYear=2023,BrandName="Fiat",DailyPrice=1000, Description="Egea" },
            //    new Car { Id = 4,BrandId = 3 , ColorId=3, ModelYear=2020,BrandName="Renault",DailyPrice=1000, Description="Megane" },
            //    new Car { Id = 5,BrandId = 4 , ColorId=4, ModelYear=2023,BrandName="Mercedes",DailyPrice=1600, Description="A180" }
                
            //};
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car CarDelete =_cars.SingleOrDefault(c=> c.Id == car.Id); 
            _cars.Remove(CarDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
           return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarUpdate);
            CarUpdate.DailyPrice = car.DailyPrice;
            CarUpdate.Description=car.Description;
            //Referansları atayarak silip güncelliyoruz.
        }
    }
}
