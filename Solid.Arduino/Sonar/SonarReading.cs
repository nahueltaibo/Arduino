using System;
using System.Collections.Generic;

namespace Solid.Arduino.Sonar
{
    /// <summary>
    /// Represents a distance measure made by the Sonar which has its echo pin configured at EchoPin.
    /// </summary>
    public struct SonarReading
    {
        /// <summary>
        /// Distances in cm measured by every RangeFinder configured in the Sonar
        /// </summary>
        public IList<int> Distances { get; set; }
    }
}
