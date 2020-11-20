//-----------------------------------------------------------------------
// <copyright company="ConsoliAds">
//     Copyright (c) Monetization_Automation. All rights reserved.
// </copyright>
// <author>Ahmad Khisal - ConsoliAds Pakistan/author>
//-----------------------------------------------------------------------

namespace Monetization_Automation.Base
{
    using System.Diagnostics;
    /// <summary>
    /// BaseModule Class contains all actions to be performed. 
    /// This class Holds Map and Validator Instances.
    /// </summary>
    /// <typeparam name="TMap">Accept Map class as parameter.</typeparam>
    /// <typeparam name="TValidator">Accept validator Class as parameter.</typeparam>
    public abstract class BasePage<TMap, TValidator>
        where TMap : BaseMap
        where TValidator : BaseValidator<TMap>
    {
        /// <summary>
        /// Map object which get and Set map object to perform actions.
        /// </summary>
        public TMap Map { get; set; }

        /// <summary>
        /// Validator object which get and Set validator object to perform actions.
        /// </summary>
        public TValidator Validator { get; set; }

        /// <summary>
        /// BaseModule Constructor which accept paramters Map and Validator and
        /// assign Map and validator parameters to internal properties Map and validator.
        /// </summary>
        /// <param name="map">Accept Map as parameters.</param>
        /// <param name="validator">Accept validator as parameter.</param>
        protected BasePage(TMap map, TValidator validator)
        {
            Map = map; Validator = validator;
        }

        /// <summary>
        /// WindowProcess property return Processes of the Application under test.
        /// </summary>
        public Process WindowProcess { get { return Map.ApplicationProcess; } }

        /// <summary>
        /// Constructor of the base module class.
        /// </summary>
        protected BasePage() { }
    }
}
