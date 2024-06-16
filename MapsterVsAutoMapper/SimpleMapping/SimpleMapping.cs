using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;
using MapsterVsAutoMapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsterVsAutoMapper.SimpleMapping
{

    [RankColumn]
    [MemoryDiagnoser]
    public class SimpleMapping
    {
        public static IMapper Mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductRequest, Product>()).CreateMapper();
        ProductRequest Request = new ProductRequest("Benchmark", "Benchmark about Mapster Vs Automapper", 30050, new List<string> { "A1", "B2" });

        [Benchmark]
        public Product AutoMapperMapping()
        {
            var entity = Mapper.Map<Product>(Request);

            return entity;
        }

        [Benchmark]
        public Product MapsterMapping()
        {
            var entity = Request.Adapt<Product>();

            return entity;
        }
    }
}
