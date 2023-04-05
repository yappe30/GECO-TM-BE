namespace gecoTM.Models.Blog
{
    public class BlogModel
    {
        public int id { get; set; }
        public string blog_name { get; set; } = string.Empty;
        public string blog_subject { get; set; } = string.Empty;
        public string blog_image { get; set; } = string.Empty;
        public string blog_description { get; set; } = string.Empty;
    }
}
