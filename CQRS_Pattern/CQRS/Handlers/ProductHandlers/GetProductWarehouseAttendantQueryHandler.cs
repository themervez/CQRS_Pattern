using CQRS_Pattern.CQRS.Results.ProductResults;
using CQRS_Pattern.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_Pattern.CQRS.Handlers.ProductHandlers
{
    public class GetProductWarehouseAttendantQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductWarehouseAttendantQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductWarehouseAttendantQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x =>
            new GetProductWarehouseAttendantQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                Warehouse=x.Warehouse
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
