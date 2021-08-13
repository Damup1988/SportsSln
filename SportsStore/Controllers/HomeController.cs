using Microsoft.AspNetCore.Mvc;
using SportsStore.Repository;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _repository;

        public HomeController(IStoreRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Products);
        }
    }
}