using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repository.UnitOfWork;
using FA.JustBlog.UI.Areas.Identity.Data;
using FA.JustBlog.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.UI.Controllers
{
    public class PostController : Controller
    {
        public const int ITEMS_PER_PAGE = 5;
        private IUnitOfWork _unitOfWork;
        private readonly UserManager<FAJustBlogUIUser> _userManager;

        public PostController(IUnitOfWork _unitOfWork, UserManager<FAJustBlogUIUser> _userManager)
        {
            this._unitOfWork = _unitOfWork;
            this._userManager = _userManager;
        }

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
            return View(posts.AsEnumerable());
        }

        public IActionResult PostDetail(int year, int month, string urlSlug)
        {
            ViewBag.PostDetail = _unitOfWork.PostRepository.FindPost(year, month, urlSlug);
            return View();
        }

        public IActionResult GetPostCategory(string category, [Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var postData = _unitOfWork.PostRepository.GetPostsByCategory(category);
            ViewBag.CategoryName = category;

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
            return View(posts.AsEnumerable());
        }

        public IActionResult GetPostTag(string tag, [Bind(Prefix = "page")] int pageNumber)
        {
            if (pageNumber == 0)
                pageNumber = 1;
            var postData = _unitOfWork.PostRepository.GetPostsByTag(tag);
            ViewBag.TagName = tag;

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
            return View(posts.AsEnumerable());
        }

        [HttpPost]
        public async Task<IActionResult> CommentPost(int postId, CommentModelView comment)
        {
            var user = await _userManager.GetUserAsync(User);
            var post = _unitOfWork.PostRepository.Find(postId);
            if (User.Identity?.IsAuthenticated ?? false)
            {
                var postcmt = new Comments
                {
                    Name = user.UserName,
                    CommentHeader = comment.CommentHeader,
                    PostId = postId,
                    CommentText = comment.CommentText,
                    Email = User.Identity.Name,
                    CommentTime = DateTime.Now
                };
                _unitOfWork.CommentRepository.Add(postcmt);
            }
            else
            {
                var postcmtuser = new Comments
                {
                    Name = comment.Name,
                    CommentHeader = comment.CommentHeader,
                    PostId = postId,
                    CommentText = comment.CommentText,
                    Email = comment.Email,
                    CommentTime = DateTime.Now
                };
                _unitOfWork.CommentRepository.Add(postcmtuser);
            }

            _unitOfWork.SaveChanges();
            return RedirectToAction("PostDetail", "Post", new
            {
                year = post.Modified.Year,
                month = post.Modified.Month,
                urlSlug = post.UrlSlug
            });
        }
    }
}
