using FA.BookStore.Core.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.UnitOfWork;
using FA.JustBlog.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        public const int ITEMS_PER_PAGE = 5;
        private IUnitOfWork _unitOfWork;
        SeoUrlHepler seoUrlHepler = new SeoUrlHepler();


        public CategoryController(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        public IActionResult Index([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var Data = _unitOfWork.CategoryRepository.GetAll();

            var totalItems = Data.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            if (pageNumber > totalPages)
                return RedirectToAction("Index", "Post", new { page = totalPages });
            var data = Data
            .Skip(ITEMS_PER_PAGE * (pageNumber - 1))
            .Take(ITEMS_PER_PAGE)
            .ToList();
            ViewBag.Data = data;
            ViewData["pageNumber"] = pageNumber;
            ViewData["totalPages"] = totalPages;
            return View();
        }

        public IActionResult CategoryDetail(int? id)
        {
            if (id.HasValue)
            {
                var category = _unitOfWork.CategoryRepository.Find(id.Value);
                return View(category);
            }
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var category = _unitOfWork.CategoryRepository.Find(id.Value);
                if (category != null)
                {
                    return View(category);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? CategoryId, CategoryModelView category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (CategoryId.HasValue)
                    {
                        _unitOfWork.CategoryRepository.Update(new Categories() { CategoryId = category.CategoryId, CategoryName = category.CategoryName, UrlSlug = seoUrlHepler.Slugify(category.CategoryName), Description = category.Description });
                        _unitOfWork.SaveChanges();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryModelView category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.CategoryRepository.Add(new Categories() { CategoryName = category.CategoryName, UrlSlug = seoUrlHepler.Slugify(category.CategoryName), Description = category.Description });
                    _unitOfWork.SaveChanges();
                    return RedirectToAction(nameof(Index));

                }
            }
            catch
            {
                return View();
            }
            return View(category);
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _unitOfWork.CategoryRepository.Delete(id.Value);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
