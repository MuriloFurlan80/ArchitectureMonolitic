using System;

namespace App.Domain.Model
{

    /// <summary>
    /// Class EntityBase object
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Indentity Guid
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Constructor Pattern
        /// </summary>
        /// <param name="id"></param>
        protected EntityBase(Guid id)
        {
            Id = id;
        }
    }
}
