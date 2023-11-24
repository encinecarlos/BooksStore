namespace BookStore.Domain.Entities
{
    public class Author : BaseEntity<Guid>
    {
        public Author()
        {
            Id = Guid.NewGuid();
        }
    }
}
