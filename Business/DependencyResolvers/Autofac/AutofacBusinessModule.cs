using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //using Autofac dedik ampulden
    {
        protected override void Load(ContainerBuilder builder)
        {   
            //API katmanında yaptığımız olayın aynısı.Data tutmayanlar için tek bir instance oluşturup hepsini orada tutuyorlar.
            //
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            //SingleInstance--CarServiceler 
        }
    }
}
