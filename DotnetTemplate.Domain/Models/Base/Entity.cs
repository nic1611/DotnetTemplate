namespace DotnetTemplate.Domain.Models.Base {
    public class Entity {

        public Guid Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get;  private set; }

        public Entity(Guid id, DateTime createAt, DateTime updateAt) {
            Id = id;
            CreateAt = createAt;
            UpdateAt = updateAt;
        }

        protected Entity() { }
    }
}
