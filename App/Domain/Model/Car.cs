using System;
using System.Text.Json.Serialization;

namespace App.Domain.Model
{
    /// <summary>
    /// Class Car
    /// </summary>
    public class Car : Vehicle
    {

        /// <summary>
        /// Identity Vehicle
        /// </summary>
        public string Chassis { get; set; }

        /// <summary>
        /// Color car
        /// </summary>
        public string Color { get; private set; }

        /// <summary>
        /// Define Model car
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        ///  Base constructor complete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        public Car(Guid id, string brand) : base(id, brand)
        {
        }

        /// <summary>
        /// Constructor complete
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Color"></param>
        /// <param name="Model"></param>
        /// <param name="Brand"></param>
        /// <param name="Chassis"></param>
        [JsonConstructor]
        public Car(Guid Id, string Color, string Model, string Brand, string Chassis) : this(Id, Brand)
            => (this.Color, this.Model, this.Chassis) = (Color, Model, Chassis);

        /// <summary>
        /// Constructor id automatic
        /// </summary>
        /// <param name="color"></param>
        /// <param name="model"></param>
        /// <param name="brand"></param>
        /// <param name="chassis"></param>
        public Car(string color, string model, string brand, string chassis) :
            this(Guid.NewGuid(), color, model, brand, chassis)
        { }
    }
}
