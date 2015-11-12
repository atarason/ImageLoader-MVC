using System;

namespace ImageLoader.Model.Entities.BaseEntities
{
    /// <summary>
    ///
    /// </summary>
    public interface ITrackCreation
    {
        /// <summary>
        ///
        /// </summary>
        DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        DateTimeOffset UpdatedDate { get; set; }
    }
}