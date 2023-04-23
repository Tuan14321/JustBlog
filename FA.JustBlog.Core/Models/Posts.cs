namespace FA.JustBlog.Core.Models
{
    public class Posts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PostContent { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DateTime PostOn { get; set; }
        public DateTime Modified { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public virtual ICollection<PostTagMap> PostTagMaps { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }
        private decimal rate;

        public decimal Rate
        {
            get { return rate; }
            set { rate = TotalRate / RateCount; }
        }

        public virtual ICollection<Comments> Comments { get; set; }


    }
}
