namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity<Guid>
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public DateTime OublicationDate { get; set; }
        public string Synopsis { get; set; }
        public string isbn { get; set; }
        public Publisher MyProperty { get; set; }
        public Language Language { get; set; }
        public IList<Format> Formats { get; set; }
        public IList<Review> Reviews { get; set; }
    }
}
