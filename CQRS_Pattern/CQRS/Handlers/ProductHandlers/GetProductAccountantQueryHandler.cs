using CQRS_Pattern.CQRS.Results.ProductResults;
using CQRS_Pattern.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_Pattern.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccountantQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccountantQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        //Sadece Accountant yetkisine sahip kişinin göreceği kısım
        public List<GetProductAccountantQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x =>
            new GetProductAccountantQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice,
                Stock = x.Stock,
                Tax=x.Tax
            }).AsNoTracking().ToList();//AsNoTracking, performans ile ilgili iyileştirme için kullanıldı

            return values;
        }
    }
}
