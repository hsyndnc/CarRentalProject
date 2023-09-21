 using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public  class CarValidator :AbstractValidator<Car> //Kurallarımızı neye göre yazacağımızı söylüyoruz.
        //Hngi nesneyle çalışması gerektiğini söylüyoruz.
    {
        public CarValidator()
        {
            //Hnagi nesne için validator yazıcaksak buraya yazıyoruz.
            
            RuleFor(c=>c.CarName).MinimumLength(2);
            RuleFor(P=>P.DailyPrice).NotEmpty();
            RuleFor(P => P.DailyPrice).GreaterThan(0); //daily price >0 olmalı
            RuleFor(p=>p.DailyPrice).GreaterThanOrEqualTo(1000).When(p=>p.BrandId==1); //Brand Id si 1 olanların fiyatı 1000 den büyük olmalıdır. 
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
            //istediğimiz bir kural varsa must ile koyuyoruz.
            //daha sonra generate method diyip aşağıda methodu oluşturuyoruz istediğimiz kurallarla ilgili
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); //eğer yazı a ile başlıyorsa true başlamıyorsa false dönen bir fonksiyon
        }
    }
}
