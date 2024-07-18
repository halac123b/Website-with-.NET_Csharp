namespace CafeDevCode.Database.Configurations
{
    internal class PlaylistVideoConfiguration : IEntityTypeConfiguration<PlaylistVideo>
    {
        public void Configure(EntityTypeBuilder<PlaylistVideo> builder)
        {
            // Xác định property Id là property của entity
            builder.HasKey(x => x.Id);
            // Config property Id sử dụng 1 identity column, tức cột đc tự sinh ra, theo index tăng dần
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}