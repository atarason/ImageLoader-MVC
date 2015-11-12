using ImageLoader.Model.Entities.BaseEntities;
using System.Data.Entity.ModelConfiguration;

namespace ImageLoader.Model.Mappings.BaseMap
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    internal class BaseMapConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : PersistentEntity
    {
        /// <summary>
        ///
        /// </summary>
        public BaseMapConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.IsActive)
               .IsRequired();

            Property(x => x.CreatedDate)
                .IsRequired();

            Property(x => x.UpdatedDate)
                .IsRequired();
        }
    }
}