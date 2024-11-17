namespace FineBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string? Tiltle { get; set; }
        public string? ShortDescription { get; set; }
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public string? Slug { get; set; }

    }
}
