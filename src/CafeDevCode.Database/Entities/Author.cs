﻿global using CafeDevCode.Common.Shared.Model;

namespace CafeDevCode.Database.Entities
{
    public class Author: BaseEntity
    {
        public int Id { get; set; }
        public string? FullName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;
        public string? ShortName { get; set; } = string.Empty;
    }
}
