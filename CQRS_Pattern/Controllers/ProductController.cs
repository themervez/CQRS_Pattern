using CQRS_Pattern.CQRS.Commands.ProductCommands;
using CQRS_Pattern.CQRS.Handlers.ProductHandlers;
using CQRS_Pattern.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Pattern.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccountantQueryHandler _getProductAccountantQueryHandler;
        private readonly GetProductWarehouseAttendantQueryHandler _getProductWarehouseAttendantQueryHandler;
        private readonly GetProductHRByIDQueryHandler _getProductHRByIDQueryHandler;
        private readonly GetProductAccountantByIDQueryHandler _getProductAccountantByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccountantQueryHandler getProductAccountantQueryHandler, GetProductWarehouseAttendantQueryHandler getProductWarehouseAttendantQueryHandler, GetProductHRByIDQueryHandler getProductHRByIDQueryHandler, GetProductAccountantByIDQueryHandler getProductAccountantByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccountantQueryHandler = getProductAccountantQueryHandler;
            _getProductWarehouseAttendantQueryHandler = getProductWarehouseAttendantQueryHandler;
            _getProductHRByIDQueryHandler = getProductHRByIDQueryHandler;
            _getProductAccountantByIDQueryHandler = getProductAccountantByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccountantQueryHandler.Handle();

            return View(values);
        }
        public IActionResult AccountantIndexByID(int id)
        {
            var values = _getProductAccountantByIDQueryHandler.Handle(new GetProductAccountantByIDQuery(id));
            return View(values);
        }
        public IActionResult WarehouseAttendantIndex()
        {
            var values = _getProductWarehouseAttendantQueryHandler.Handle();

            return View(values);
        }
        public IActionResult GetHRByIDIndex(int id) 
        { 
            var values=_getProductHRByIDQueryHandler.Handle(new GetProductHRByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
