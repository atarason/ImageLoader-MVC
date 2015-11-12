using ImageLoader.Model.Abstraction;
using ImageLoader.Model.Entities;
using ImageLoader.Model.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ImageLoader.Model.Contexts
{
    public class ImageLoaderContext : DbContext, IImageLoaderContext
    {
        #region Constructors

        /// <summary>
        ///
        /// </summary>
        static ImageLoaderContext()
        {
            Database.SetInitializer<ImageLoaderContext>(null);
        }

        /// <summary>
        ///
        /// </summary>
        public ImageLoaderContext()
            : base("ImageLoaderContext")
        {
        }

        #endregion Constructors

        #region Public Properties

        public DbSet<Image> Images { get; set; }

        #endregion Public Properties

        /// <summary>
        ///
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Drop cascade remove
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #region Map Files

            modelBuilder.Configurations.Add(new ImageMap());

            #endregion Map Files
        }

        /// <summary>
        /// Create object instanse of dbContext
        /// </summary>
        /// <returns></returns>
        public static ImageLoaderContext Create()
        {
            return new ImageLoaderContext();
        }
    }
}