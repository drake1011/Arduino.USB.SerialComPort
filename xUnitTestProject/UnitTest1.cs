using System;
using Xunit;
using Arduino.USB.SerialComPort;

namespace xUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ports = COMPortInfo.GetCOMPortsInfo();
            Assert.NotNull(ports);
            Assert.NotEmpty(ports);
        }
    }
}
