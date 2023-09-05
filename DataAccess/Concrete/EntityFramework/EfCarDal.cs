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

namespace DataAccess.Concrete.EntityFramework
{
    //DacaAccess üzerinden manage nuGet Packages e girip MicrosoftEntitiy Framework.sql i indiriyoruz.Packageslerde görebiliyoruz.
    //EfCarDal IcarDal ın referansını kullanıyor ICarDal da IEntityRepositorynin referansını kullanabiliyor.

    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                //Referansı yakaladık
                addedEntity.State = EntityState.Added;
                //Eklenebilir bir nesne olduğunu söyledik 
                context.SaveChanges();
                //işlemleri yaptık.
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
                //SingleOrDefault--Verilen filtreye uygun tek datayı getirmeye yarar.
                //Bir Linq metodudur.
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                //Return Operatörü
                //filter ==null ise ilk komutu uygula değil ise ikinci komutu uygula
                //Yani  null değilse filter ikinci kısım çalışır.


            }
            
        }

        public Car GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified; 
                context.SaveChanges();
                
            }
        }
    }
}
