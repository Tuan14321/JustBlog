﻿namespace FA.JustBlog.Core.Models
{
    public class Tags
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public virtual ICollection<PostTagMap> PostTagMaps { get; set; }
    }
}
