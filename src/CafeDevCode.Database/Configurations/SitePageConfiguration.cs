namespace CafeDevCode.Database.Configurations
{
    internal class SitePageConfiguration : IEntityTypeConfiguration<SitePage>
    {
        public void Configure(EntityTypeBuilder<SitePage> builder)
        {
            // Xác định property Id là property của entity
            builder.HasKey(x => x.Id);
            // Config property Id sử dụng 1 identity column, tức cột đc tự sinh ra, theo index tăng dần
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}

