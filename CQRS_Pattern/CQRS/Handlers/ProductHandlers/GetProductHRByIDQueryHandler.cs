using CQRS_Pattern.CQRS.Queries.ProductQueries;
using CQRS_Pattern.CQRS.Results.ProductResults;
using CQRS_Pattern.DAL.Context;

namespace CQRS_Pattern.CQRS.Handlers.ProductHandlers
{
    public class GetProductHRByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHRByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductHRByIDQueryResult Handle(GetProductHRByIDQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductHRByIDQueryResult
            {
                ID = values.ID,
                Name = values.Name,
                Brand = values.Brand,
                SalePrice = values.SalePrice
            };

        }
    }
}
