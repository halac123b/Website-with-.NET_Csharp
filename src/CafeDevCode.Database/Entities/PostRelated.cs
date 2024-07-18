namespace CafeDevCode.Database.Entities
{
    public class PostRelated : BaseEntity
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public int? RelatedId { get; set; }
    }
}
