using ImageLoader.Model.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace ImageLoader.Model.Entities
{
    /// <summary>
    ///
    /// </summary>
    public class Image : PersistentEntity
    {
        /// <summary>
        ///
        /// </summary>
        [Url]
        public string Url { get; set; }
    }
}