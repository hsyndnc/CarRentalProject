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

namespace DataAccess.Concrete.EntityFramework
{
    //DacaAccess üzerinden manage nuGet Packages e girip MicrosoftEntitiy Framework.sql i indiriyoruz.Packageslerde görebiliyoruz.
    //EfCarDal IcarDal ın referansını kullanıyor ICarDal da IEntityRepositorynin referansını kullanabiliyor.

    public class EfCarDal :IEntityRepositoryBase<Car ,CarRentalContext> ,ICarDal
    {
        //IcarDal ın tüm imzalarına IEntityReposityoryBase  sahip o yüzden onu eklediğimizde sorun ortadan kalkıyor.
        
    }
}
