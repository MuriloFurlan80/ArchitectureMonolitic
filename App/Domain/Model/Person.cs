using System;

namespace App.Domain.Model
{
    /// <summary>
    /// Class Person object
    /// </summary>
    public class Person : EntityBase
    {
        #region Properties
        /// <summary>
        /// Property name 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Property gender 
        /// </summary>
        public string Gender { get; private set; }

        /// <summary>
        /// Property email 
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Property phone
        /// </summary>
        public string Phone { get; private set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Construct Pattern
        /// </summary>
        /// <param name="id"></param>
        public Person(Guid id) : base(id)
        { }

        /// <summary>
        /// Constructor complete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        public Person(Guid id, string name, string gender, string email, string phone) : this(id)
            => (Name, Gender, Email, Phone) = (name, gender, email, phone);

        /// <summary>
        /// Constructor generate id automatic
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        public Person(string name, string gender, string email, string phone)
            : this(Guid.NewGuid(), name, gender, email, phone) { }
        #endregion

    }
}
