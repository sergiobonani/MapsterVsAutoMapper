using BenchmarkDotNet.Running;
using MapsterVsAutoMapper.SimpleMapping;

var summary = BenchmarkRunner.Run<SimpleMapping>();

public record ProductRequest(string Name, string Description, decimal Price, List<string> Tags);
