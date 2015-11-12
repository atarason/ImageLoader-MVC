using System;

namespace ImageLoader.Model.Entities.BaseEntities
{
    /// <summary>
    ///
    /// </summary>
    public abstract class PersistentEntity : IPersistentEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// staus of item
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// Created date of item
        /// </summary>
        public virtual DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Updated date of item
        /// </summary>
        public virtual DateTimeOffset UpdatedDate { get; set; }
    }
}