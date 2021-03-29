// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cvr.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Company Event the user has subscribed to
    /// </summary>
    public partial class SubscribedCompanyEvents
    {
        /// <summary>
        /// Initializes a new instance of the SubscribedCompanyEvents class.
        /// </summary>
        public SubscribedCompanyEvents()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscribedCompanyEvents class.
        /// </summary>
        /// <param name="actualCount">Number of CVR events fetched prior to
        /// filtering to just the subscribed companies</param>
        /// <param name="events">The events filtered by subscription</param>
        public SubscribedCompanyEvents(int actualCount, IList<CompanyEvent> events = default(IList<CompanyEvent>))
        {
            Events = events;
            ActualCount = actualCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the events filtered by subscription
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<CompanyEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets number of CVR events fetched prior to filtering to
        /// just the subscribed companies
        /// </summary>
        [JsonProperty(PropertyName = "actualCount")]
        public int ActualCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}