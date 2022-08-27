namespace PensePositivoAPI.Models
{
    public class Text
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}