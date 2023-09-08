using DataAccess.Abstract;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    //DacaAccess üzerinden manage nuGet Packages e girip MicrosoftEntitiy Framework.sql i indiriyoruz.Packageslerde görebiliyoruz.
    //EfCarDal IcarDal ın referansını kullanıyor ICarDal da IEntityRepositorynin referansını kullanabiliyor.

    public class EfCarDal : IEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        //IcarDal ın tüm imzalarına IEntityReposityoryBase  sahip o yüzden onu eklediğimizde sorun ortadan kalkıyor.
        public List<CarDetailDto> GetDetails()
        {


            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}

