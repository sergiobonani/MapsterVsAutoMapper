using BenchmarkDotNet.Attributes;
using Mapster;
using MapsterVsAutoMapper.Model;

namespace MapsterVsAutoMapper.SimpleMapping
{
    [MemoryDiagnoser]
    public class MapsterMapping
    {
        [Benchmark]
        public static Product Map(ProductRequest request)
        {
            var entity = request.Adapt<Product>();

            return entity;
        }
    }
}
