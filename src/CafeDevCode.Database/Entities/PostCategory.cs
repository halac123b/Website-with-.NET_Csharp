﻿namespace CafeDevCode.Database.Entities
{
    public class PostCategory: BaseEntity
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? PostId { get; set; }
    }
}
