﻿namespace CafeDevCode.Database.Entities
{
    public class PostTag : BaseEntity
    {
        public int Id { get; set; }
        public int? TagId { get; set; }
        public int? PostId { get; set; }
    }
}
