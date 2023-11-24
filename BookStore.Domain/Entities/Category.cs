namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}
