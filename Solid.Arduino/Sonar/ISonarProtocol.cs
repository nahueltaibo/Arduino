using Solid.Arduino.Firmata;

namespace Solid.Arduino.Sonar
{
    /// <summary>
    /// Defines Sonar control related members of the Firmata protocol.
    /// </summary>
    /// <remarks>
    /// This interface is separated from the <see cref="IFirmataProtocol"/> interface, in order to
    /// protect the latter against feature bloat. 
    /// </remarks>
    public interface ISonarProtocol
    {
        /// <summary>
        /// Configures the minimum and maximum pulse length for a servo pin.
        /// </summary>
        /// <param name="triggerPin">The pin number connected to the sonars trigger pin</param>
        /// <param name="echoPin">Minimum pulse length</param>
        /// <param name="maxDistance">Maximum pulse length</param>
        void ConfigureSonar(byte triggerPin, byte echoPin, int maxDistance);

        /// <summary>
        /// Configures the interval between sensor pings (29ms is the min to avoid cross-sensor echo).
        /// </summary>
        /// <param name="interval">Milliseconds between sensor pings</param>
        void ConfigurePingInterval(byte interval);
    }
}
