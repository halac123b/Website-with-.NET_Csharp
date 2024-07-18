namespace CafeDevCode.Database.Entities
{
    public class Playlist: BaseEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? UrlMeta { get; set; }
        public string? Keywords { get; set; }
        public int? SortIndex { get; set; }
    }
}
