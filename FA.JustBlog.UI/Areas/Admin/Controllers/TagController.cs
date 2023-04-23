using FA.BookStore.Core.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.UnitOfWork;
using FA.JustBlog.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        public const int ITEMS_PER_PAGE = 5;
        private IUnitOfWork _unitOfWork;
        SeoUrlHepler seoUrlHepler = new SeoUrlHepler();

        public TagController(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public IActionResult Index([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var data = _unitOfWork.TagRepository.GetAll();

            var totalItems = data.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            if (pageNumber > totalPages)
                return RedirectToAction("Index", "Post", new { page = totalPages });
            var dataPaging = data
            .Skip(ITEMS_PER_PAGE * (pageNumber - 1))
            .Take(ITEMS_PER_PAGE)
            .ToList();
            ViewBag.Data = dataPaging;
            ViewData["pageNumber"] = pageNumber;
            ViewData["totalPages"] = totalPages;
            return View();
        }

        public IActionResult TagDetail(int? id)
        {
            if (id.HasValue)
            {
                var tag = _unitOfWork.TagRepository.Find(id.Value);
                return View(tag);
            }
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var tag = _unitOfWork.TagRepository.Find(id.Value);
                if (tag != null)
                {
                    return View(tag);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? TagId, TagModelView tag)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (TagId.HasValue)
                    {
                        _unitOfWork.TagRepository.Update(new Tags()
                        {
                            TagId = tag.TagId,
                            TagName = tag.TagName,
                            UrlSlug = seoUrlHepler.Slugify(tag.TagName),
                            Description = tag.Description,
                            Count = tag.Count,
                        });
                        _unitOfWork.SaveChanges();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TagModelView tag)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.TagRepository.Add(new Tags() { TagName = tag.TagName, UrlSlug = seoUrlHepler.Slugify(tag.TagName), Description = tag.Description });
                    _unitOfWork.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View(tag);
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _unitOfWork.TagRepository.Delete(id.Value);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
