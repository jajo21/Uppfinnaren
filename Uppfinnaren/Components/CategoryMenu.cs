using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Uppfinnaren.Models;

namespace Uppfinnaren.Components
{
    public class CategoryMenu : ViewComponent // ViewComponent = en bas-ViewComponent klass som kommer från ASP.MVC
    {
        //Behöver komma åt datan från model-repositorys, använder interface för det.
        private readonly ICategoryRepository _categoryRepository;

        //Konstrukturn tar en inparameter som redan är "registrerad" i startup-filen under services.
        //Det här gör att vi kommer åt modelklasserna genom controllern
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //Hämtar en lista av alla kategorier som ska visa menyn och vilka kategorier som finns tillgängliga.
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryId);
            return View(categories);
        }
    }
}
