using System;

namespace Solid.Arduino.Sonar
{
    /// <summary>
    /// Represents a distance measure made by the Sonar which has its echo pin configured at EchoPin.
    /// </summary>
    public struct SonarReading
    {
        /// <summary>
        /// EchoPin of the Sonar that made the reading
        /// </summary>
        public byte EchoPin { get; set; }

        /// <summary>
        /// Distance in cm measured by the Sonar
        /// </summary>
        public int Distance { get; set; }
    }
}
