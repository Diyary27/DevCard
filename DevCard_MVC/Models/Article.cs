namespace DevCard_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Article(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
