// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cvr.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProductionUnit
    {
        /// <summary>
        /// Initializes a new instance of the ProductionUnit class.
        /// </summary>
        public ProductionUnit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductionUnit class.
        /// </summary>
        public ProductionUnit(string pNumber = default(string), string productionUnitName = default(string))
        {
            PNumber = pNumber;
            ProductionUnitName = productionUnitName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pNumber")]
        public string PNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productionUnitName")]
        public string ProductionUnitName { get; set; }

    }
}