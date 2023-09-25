﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        //public string? BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public string? Description { get; set; }
        public string CarName { get; set; }
        public int CategoryId { get; set; }
    }
}
