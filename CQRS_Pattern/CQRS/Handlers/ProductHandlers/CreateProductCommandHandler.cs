using CQRS_Pattern.CQRS.Commands.ProductCommands;
using CQRS_Pattern.DAL.Context;
using CQRS_Pattern.DAL.Entities;

namespace CQRS_Pattern.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)//void
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ExpirationDate = command.ExpirationDate,
                ProductionDate = command.ProductionDate,
                Status = command.Status
            });
            _productContext.SaveChanges();
        }
    }
}
