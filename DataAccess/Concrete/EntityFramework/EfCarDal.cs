using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter =null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                                 {
                                     CarId = c.CarId, 
                                     BrandName = b.BrandName,
                                     ColorName = cl.ColorName, 
                                     ModelYear = c.ModelYear,
                                     DailyPrice = c.DailyPrice, 
                                     Description = c.Description,
                                     CarImages = ((from ci in context.CarImages
                                         where (c.CarId == ci.CarId)
                                         select new CarImage
                                         {
                                             CarId = ci.CarId,
                                             CarImageId = ci.CarImageId,
                                             ImagePath = ci.ImagePath
                                         }).ToList())
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

        
    }
}
