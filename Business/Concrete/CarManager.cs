﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

            ValidationTool.Validate(new CarValidator(),car);

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }




        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int id)
        {

            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
            //return new SuccessDataResult<Car>(_carDal.GetAll(c => c.Id == id));

        }

        public IDataResult<List<Car>> GetCarsByBranID(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(t => t.BrandId == id));


        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));

        }

        public IDataResult<List<CarDetailDto>> GetDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetDetails());
        }


        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetDetails(), "Car details provided!");

        }

        public IDataResult<List<Color>> GetColors()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetbyCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CategoryId == categoryId));
        }
    }

}


