namespace CafeDevCode.Common.Shared.Model
{
    /// <summary>
    /// Contain date about update (User, time)
    /// </summary>
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? LastUpdatedBy { get;set; }
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity SetCreateInfo(string user, DateTime date) {
            CreatedBy = user;
            CreatedAt = date;
            return this;
        }

        public BaseEntity SetUpdateInfo(string user, DateTime date)
        {
            LastUpdatedBy = user;
            LastUpdatedAt = date;
            return this;
        }
    }
}
