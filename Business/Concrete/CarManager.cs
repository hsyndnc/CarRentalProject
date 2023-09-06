﻿using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.BrandName.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Araç Eklendi");


            }
            else
            {
                Console.WriteLine("Araç İsmi minimum 2 karakter, araç günlük fiyatı geçerli rakam olmalıdır!");
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
