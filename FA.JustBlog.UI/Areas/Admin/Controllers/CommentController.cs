using FA.BookStore.Core.Common;
using FA.JustBlog.Core.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CommentController : Controller
    {
        public const int ITEMS_PER_PAGE = 5;
        private IUnitOfWork _unitOfWork;
        SeoUrlHepler seoUrlHepler = new SeoUrlHepler();

        public CommentController(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public IActionResult Index([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var data = _unitOfWork.CommentRepository.GetAll();

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

        public IActionResult CommentDetail(int? id)
        {
            if (id.HasValue)
            {
                var comment = _unitOfWork.CommentRepository.Find(id.Value);
                return View(comment);
            }
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _unitOfWork.CommentRepository.Delete(id.Value);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
