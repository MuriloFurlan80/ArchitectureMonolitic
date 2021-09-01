using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Domain.Model
{
    /// <summary>
    /// Class Motocycle
    /// </summary>
    public class Motocycle : Vehicle
    {

        /// <summary>
        /// Identity Vehicle
        /// </summary>
        public string Chassis { get; set; }

        /// <summary>
        /// Color Motocycle
        /// </summary>
        public string Color { get; private set; }

        /// <summary>
        /// Define Model Motocycle
        /// </summary>
        public string Model { get; private set; }

    /// <summary>
    ///  Base constructor complete
    /// </summary>
    /// <param name="id"></param>
    /// <param name="brand"></param>
    public Motocycle(Guid id, string brand) : base(id, brand)
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
    public Motocycle(Guid Id, string Color, string Model, string Brand, string Chassis) : this(Id, Brand)
        => (this.Color, this.Model, this.Chassis) = (Color, Model, Chassis);

    /// <summary>
    /// Constructor id automatic
    /// </summary>
    /// <param name="color"></param>
    /// <param name="model"></param>
    /// <param name="brand"></param>
    /// <param name="chassis"></param>
    public Motocycle(string color, string model, string brand, string chassis) :
        this(Guid.NewGuid(), color, model, brand, chassis)
    { }
}
    }
}
