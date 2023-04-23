using System.Text.RegularExpressions;

namespace FA.BookStore.Core.Common
{
    public class SeoUrlHepler
    {
        public string ToUrlSlug(string input)
        {
            // Chuyển đổi chuỗi sang chữ thường
            string lowerCase = input.ToLower();

            // Loại bỏ các ký tự không phải là chữ cái hoặc số và thay thế bằng dấu gạch ngang
            string urlSlug = Regex.Replace(lowerCase, @"[^a-z0-9\s-]", "")
               .Replace(' ', '-');

            // Loại bỏ những dấu gạch ngang lặp lại
            urlSlug = Regex.Replace(urlSlug, @"-{2,}", "-");

            // Xóa ký tự gạch ngang ở đầu và cuối chuỗi nếu có
            urlSlug = urlSlug.Trim('-');

            return urlSlug;
        }

        public string Slugify(string str)
        {
            str = str.ToLower().Trim();
            str = Regex.Replace(str, @"[^a-z0-9 -]", "");
            str = Regex.Replace(str, @"\s+", "-");
            return str;
        }
    }
}
