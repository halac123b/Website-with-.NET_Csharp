namespace CafeDevCode.Database.Configurations
{
    internal class PostTypeConfiguration : IEntityTypeConfiguration<PostType>
    {
        public void Configure(EntityTypeBuilder<PostType> builder)
        {
            // Xác định property Id là property của entity
            builder.HasKey(x => x.Id);
            // Config property Id sử dụng 1 identity column, tức cột đc tự sinh ra, theo index tăng dần
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
