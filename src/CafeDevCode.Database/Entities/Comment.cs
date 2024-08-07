﻿namespace CafeDevCode.Database.Entities
{
    public class Comment : BaseEntity
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int? ParentId { get; set; }
        public int? PostId { get; set; }
        public int? VideoId { get; set; }
    }
}
