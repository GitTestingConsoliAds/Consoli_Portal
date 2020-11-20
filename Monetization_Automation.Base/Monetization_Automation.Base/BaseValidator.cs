//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

namespace Monetization_Automation.Base
{
    /// <summary>
    /// Assertion and Validation of Module are done in this class.
    /// The base validator holds the isntance of the Map object to Find 
    /// control to perform assertion against.
    /// </summary>
    /// <typeparam name="TMap">Accept Map Object as paramter.</typeparam>
    public abstract class BaseValidator<TMap> where TMap : BaseMap
    {
        /// <summary>
        /// Get or Set Map Object.
        /// </summary>
        public TMap Map { get; set; }

        /// <summary>
        /// Set map object at constructor level.
        /// </summary>
        /// <param name="map"></param>
        protected BaseValidator(TMap map) { Map = map; }

        /// <summary>
        /// internal constructor.
        /// </summary>
        protected BaseValidator() { }
    }
}
