namespace Solid.Arduino
{
    /// <summary>
    /// Defines the communication protocol with Andar's Backbone
    /// </summary>
    public interface IAndarBackboneProtocol
    {
        /// <summary>
        /// Configures the minimum and maximum pulse length for a servo pin.
        /// </summary>
        /// <param name="acceleration">Acceleration to set to the motors</param>
        /// <param name="leftSpeed">Speed to set to the left motor</param>
        /// <param name="rightSpeed">Speed to set to the right motor</param>
        void UpdateMotors(byte acceleration, int leftSpeed, int rightSpeed);
    }
}