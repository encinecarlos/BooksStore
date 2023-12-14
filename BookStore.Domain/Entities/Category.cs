namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
