using ImageLoader.Model.Entities;
using ImageLoader.Model.Mappings.BaseMap;

namespace ImageLoader.Model.Mappings
{
    /// <summary>
    ///
    /// </summary>
    internal class ImageMap : BaseMapConfiguration<Image>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageMap()
        {
            Property(x => x.Url)
                .IsMaxLength()
                .IsRequired();
        }
    }
}