using System;

namespace ImageLoader.Model.Entities.BaseEntities
{
    /// <summary>
    ///
    /// </summary>
    public interface IPersistentEntity : IStateEntity, ITrackCreation
    {
        /// <summary>
        ///
        /// </summary>
        Guid Id { get; set; }
    }
}