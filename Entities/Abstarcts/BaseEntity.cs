namespace Entities.Abstarcts
{
    public class BaseEntity : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ChangedDate { get; set; }
    }
}
