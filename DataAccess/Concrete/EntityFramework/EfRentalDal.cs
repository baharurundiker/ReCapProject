using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext() )
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join c in context.Cars
                             on re.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CustomerId = cu.CustomerId,
                                 CarId = c.Id,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate

                             };
                return result.ToList();
                             

            }
        }
    }
}
