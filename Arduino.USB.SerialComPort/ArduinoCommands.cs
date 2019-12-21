using System;

namespace Arduino.USB.SerialComPort
{
    public sealed class ArduinoCommands
    {
        private readonly String name;
        private readonly int value;

        public static implicit operator string(ArduinoCommands op) { return op.name; }
        public static readonly ArduinoCommands ERROR = new ArduinoCommands(3, "ERROR");
        //public static readonly ArduinoCommands WAIT = new ArduinoCommands(3, "/WAIT");
        public static readonly ArduinoCommands END_WRITE = new ArduinoCommands(3, "END_WRITE");
        public static readonly ArduinoCommands TIMEOUT = new ArduinoCommands(3, "TIMEOUT");

        private ArduinoCommands(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
