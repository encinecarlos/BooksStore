namespace BookStore.Domain.Entities
{
    public class Author : BaseEntity<Guid>
    {
        public Author()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
    }
}
