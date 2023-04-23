using FA.BookStore.Core.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.UnitOfWork;
using FA.JustBlog.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FA.JustBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostController : Controller
    {
        public const int ITEMS_PER_PAGE = 5;
        private IUnitOfWork _unitOfWork;
        SeoUrlHepler seoUrlHepler = new SeoUrlHepler();

        public PostController(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        //[Authorize(Roles = "Blog Owner")]
        public IActionResult Index([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var postData = _unitOfWork.PostRepository.GetAll();

            var totalItems = postData.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            if (pageNumber > totalPages)
                return RedirectToAction("Index", "Post", new { page = totalPages });
            var posts = postData
            .Skip(ITEMS_PER_PAGE * (pageNumber - 1))
            .Take(ITEMS_PER_PAGE)
            .ToList();
            ViewBag.PostData = posts;
            ViewData["pageNumber"] = pageNumber;
            ViewData["totalPages"] = totalPages;
            var category = _unitOfWork.CategoryRepository.GetAll();
            ViewBag.Category = new SelectList(category, "CategoryId", "CategoryName");
            return View();
        }

        public IActionResult PostAdminDetail(int? id)
        {
            if (id.HasValue)
            {
                var Post = _unitOfWork.PostRepository.Find(id.Value);
                return View(Post);
            }
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var post = _unitOfWork.PostRepository.Find(id.Value);
                if (post != null)
                {
                    var category = _unitOfWork.CategoryRepository.GetAll();
                    ViewBag.Category = new SelectList(category, "CategoryId", "CategoryName");
                    return View(post);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? PostId, PostModelView Post)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (PostId.HasValue)
                    {
                        _unitOfWork.PostRepository.Update(new Posts()
                        {
                            PostId = Post.PostId,
                            Title = Post.Title,
                            ShortDescription = Post.ShortDescription,
                            PostContent = Post.PostContent,
                            UrlSlug = seoUrlHepler.Slugify(Post.Title),
                            Published = Post.Published,
                            PostOn = Convert.ToDateTime(Post.PostOn),
                            Modified = DateTime.Now,
                            CategoryId = Post.CategoryId,

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
            return View(Post);
        }

        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostModelView Post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.PostRepository.Add(new Posts()
                    {
                        Title = Post.Title,
                        ShortDescription = Post.ShortDescription,
                        PostContent = Post.PostContent,
                        UrlSlug = seoUrlHepler.Slugify(Post.Title),
                        Published = Post.Published,
                        PostOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = Post.CategoryId,
                    });
                    _unitOfWork.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View(Post);
        }

        [Authorize("Blog Owner")]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _unitOfWork.PostRepository.Delete(id.Value);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult LatestPost()
        {
            var postData = _unitOfWork.PostRepository.GetLatestPost(5);
            ViewBag.PostData = postData;
            return View();
        }

        public IActionResult MostViewPost()
        {
            var postData = _unitOfWork.PostRepository.GetMostViewedPost(5);
            ViewBag.PostData = postData;
            return View();
        }

        public IActionResult PublishedPosts([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var postData = _unitOfWork.PostRepository.GetPublisedPosts();

            var totalItems = postData.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            if (pageNumber > totalPages)
                return RedirectToAction("PublishedPosts", "Post", new { page = totalPages });
            var posts = postData
            .Skip(ITEMS_PER_PAGE * (pageNumber - 1))
            .Take(ITEMS_PER_PAGE)
            .ToList();
            ViewBag.PostData = posts;
            ViewData["pageNumber"] = pageNumber;
            ViewData["totalPages"] = totalPages;
            return View();
        }

        public IActionResult UnPublishedPosts([Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var postData = _unitOfWork.PostRepository.GetUnpublisedPosts();

            var totalItems = postData.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / ITEMS_PER_PAGE);
            if (pageNumber > totalPages)
                return RedirectToAction("UnPublishedPosts", "Post", new { page = totalPages });
            var posts = postData
            .Skip(ITEMS_PER_PAGE * (pageNumber - 1))
            .Take(ITEMS_PER_PAGE)
            .ToList();
            ViewBag.PostData = posts;
            ViewData["pageNumber"] = pageNumber;
            ViewData["totalPages"] = totalPages;
            return View();
        }
    }
}
