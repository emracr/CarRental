using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var query = from c in context.Cars
                            join b in context.Brands
                            on c.BrandId equals b.Id
                            join cr in context.Colors
                            on c.ColorId equals cr.Id
                            select new CarDetailDto {
                                Id = c.Id,
                                CarName = c.Description,
                                BrandName = b.Name,
                                ColorName = cr.Name,
                                DailyPrice = c.DailyPrice
                            };

                return query.ToList();
            }
        }
    }
}
