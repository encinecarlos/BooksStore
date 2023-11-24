namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity<Guid>
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }
    }
}
