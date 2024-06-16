using AutoMapper;
using BenchmarkDotNet.Attributes;
using MapsterVsAutoMapper.Model;

namespace MapsterVsAutoMapper.SimpleMapping
{
    [MemoryDiagnoser]
    public class AutoMapperMapping
    {
        public static IMapper Mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductRequest, Product>()).CreateMapper();
        [Benchmark]
        public static Product Map(ProductRequest request)
        {
            var entity = Mapper.Map<Product>(request);

            return entity;
        }        
    }    
}
