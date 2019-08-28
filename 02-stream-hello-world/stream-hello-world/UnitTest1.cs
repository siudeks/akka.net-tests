using Akka;
using Akka.Actor;
using Akka.Streams;
using Akka.Streams.Dsl;
using FluentAssertions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace stream_hello_world
{
    public class HelloStream
    {
        [Fact]
        public async Task ShouldAggregate()
        {
            using (var system = ActorSystem.Create("test"))
            using (var mat = system.Materializer())
            {
                var source = Source.From(Enumerable.Range(1, 3));
                var actual = await source
                    .Aggregate(1, (agg, v) => agg + v)
                    .RunWith(Sink.First<int>(), mat);
                actual.Should().Be(1 + 1 + 2 + 3);
            }
        }
    }
}
