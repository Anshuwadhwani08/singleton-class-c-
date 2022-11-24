using Xunit;
using counter_with_singleton_class;
using static counter_with_singleton_class.Program;

namespace TestCounter
{
    public class UnitTest1
    {
        counter_with_singleton_class.Program program = new counter_with_singleton_class.Program();

        [Fact]
        public void Testforincrement()
        {
            var a = Counter.GetCounter();
            Assert.Equal(11, a.Increment);

        }
        [Fact]
        public void Testfordecrement()
        {
            var a = Counter.GetCounter();
            Assert.Equal(9, a.Decrement);

        }
    }
}