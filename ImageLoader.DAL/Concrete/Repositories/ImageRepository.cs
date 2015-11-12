using ImageLoader.DAL.Abstraction.Repositories;
using ImageLoader.Model.Abstraction;
using ImageLoader.Model.Entities;

namespace ImageLoader.DAL.Concrete.Repositories
{
    /// <summary>
    ///
    /// </summary>
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="dbContext"></param>
        public ImageRepository(IImageLoaderContext dbContext)
            : base(dbContext)
        {
        }
    }
}