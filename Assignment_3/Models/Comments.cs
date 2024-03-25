namespace Assignment3.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Images { get; set; }
        public string CommentText { get; set; }
    }
}
