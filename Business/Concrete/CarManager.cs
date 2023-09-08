﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Business katmanının etkileşim kurduğu tek yer IcarDal
    //Entity Katmanı ile bağlantısı direkt yok

    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                return new SuccessResult(Messages.CarAdded);
                _carDal.Add(car);

            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);              
            }
               
            
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBranID(int id)
        {
            var cars = _carDal.GetAll(t => t.BrandId == id).ToList();

            return cars;
        }

        public List<Car> GetCarsByColorId(int id)
        {
            var cars = _carDal.GetAll(c => c.Id == id).ToList();
            return cars;
        }

        public List<CarDetailDto> GetDetails()
        {
            return _carDal.GetDetails();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

       

       
    }
}
