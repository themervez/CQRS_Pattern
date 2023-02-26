using CQRS_Pattern.CQRS.Queries.ProductQueries;
using CQRS_Pattern.CQRS.Results.ProductResults;
using CQRS_Pattern.DAL.Context;

namespace CQRS_Pattern.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccountantByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccountantByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductAccountantByIDQueryResult Handle(GetProductAccountantByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductAccountantByIDQueryResult
            {
                ID = values.ID,
                Name=values.Name,
                Brand = values.Brand,
                Description =values.Description,
                PurchasePrice=values.PurchasePrice,
                SalePrice=values.SalePrice,
                Stock=values.Stock,
                Tax=values.Tax           
            };
        }
    }
}
