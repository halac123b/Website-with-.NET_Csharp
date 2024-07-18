namespace CafeDevCode.Database.Configurations
{
    internal class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            // Xác định property Id là property của entity
            builder.HasKey(x => x.Id);
            // Config property Id sử dụng 1 identity column, tức cột đc tự sinh ra, theo index tăng dần
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
