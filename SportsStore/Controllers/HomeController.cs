using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Repository;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repository)
        {
            _repository = repository;
        }
        public ViewResult Index(int productPage = 1)
        {
            return View(_repository.Products.OrderBy(p =>
                p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize));
        }
    }
}