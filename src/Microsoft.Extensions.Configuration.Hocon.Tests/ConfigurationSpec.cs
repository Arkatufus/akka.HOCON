using System;
using Xunit;

namespace Microsoft.Extensions.Configuration.Hocon.Tests
{
    public class ConfigurationSpec
    {
        [Fact]
        public void ShouldBeAbleToConvertHoconFile()
        {
            var config = new ConfigurationBuilder().AddHoconFile("reference.conf", optional:false, reloadOnChange:true).Build();
            Assert.Equal("0.0.1 Akka", config["akka:version"]);
            Assert.Equal("Akka.Actor.LocalActorRefProvider", config["akka:actor:provider"]);
            Assert.Equal("512", config["akka:io:tcp:direct-buffer-pool:buffer-size"]);
        }

        [Fact]
        public void ShouldReloadConfigurationOnFileChange()
        {

        }
    }
}