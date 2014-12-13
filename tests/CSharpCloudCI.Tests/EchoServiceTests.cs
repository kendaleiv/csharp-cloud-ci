using Xunit;

namespace CSharpCloudCI.Tests
{
    public class EchoServiceTests
    {
        private readonly EchoService _sut;

        public EchoServiceTests()
        {
            _sut = new EchoService();
        }

        [Fact]
        public void EchosNull()
        {
            Assert.Null(_sut.Echo(null));
        }

        [Fact]
        public void EchosEmptyString()
        {
            Assert.Equal(string.Empty, _sut.Echo(string.Empty));
        }

        [Fact]
        public void EchosText()
        {
            Assert.Equal("test", _sut.Echo("test"));
        }
    }
}