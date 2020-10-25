using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MbmStore.Infrastructure;

namespace MbmStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(Repository.Products
.Select(x => x.Category).Distinct().OrderBy(x => x));
        }
    }
}


//In the Invoke method, we use LINQ to select and order the set of categories in the repository 
//and pass them as the argument to the View method, which renders the default Razor view, 
//details of which are returned from the method using an IViewComponentResult object.