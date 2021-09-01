using System;

namespace App.Domain.Model
{
    /// <summary>
    /// Vehicle Class
    /// </summary>
    public abstract class Vehicle : EntityBase
    {
        #region Properties
        /// <summary>
        /// Model Vehicle
        /// </summary>
        protected string Brand { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Pattern
        /// </summary>
        /// <param name="id">Property Indentity</param>
        protected Vehicle(Guid id) : base(id) { }

        /// <summary>
        /// Constructor complete
        /// </summary>
        /// <param name="id">Property Indentity</param>
        /// <param name="brand"> Property brand </param>
        protected Vehicle(Guid id, string brand) : this(id) =>
            (Brand) = (brand);
        #endregion
    }
}
