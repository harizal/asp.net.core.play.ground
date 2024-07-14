using Microsoft.AspNetCore.Mvc;
using Project.Core.Entities.Business;
using Project.Core.Interfaces.IServices;

namespace Project.Web.Controllers
{
    public class ProductController(IProductService productService) : Controller
    {
        private readonly IProductService _productService = productService;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetProducts()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();

            var jsonData = new
            {
                draw = draw,
                recordsFiltered = 10,
                recordsTotal = 10,
                data = new List<ProductViewModel>
                {
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A1", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A2", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A3", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A4", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A5", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A6", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A7", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A8", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A9", CreatedBy = "A" },
                    new ProductViewModel{ Id = Guid.NewGuid(), Name = "A10", CreatedBy = "A" }
                }
            };
            return Ok(jsonData);
        }
    }
}
