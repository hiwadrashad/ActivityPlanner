using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using NBench;
using System;
using System.Linq;

namespace BenchMarkExecution
{
    class Program
    {
          private Counter _counter;

        [PerfSetup]
        public void Setup(BenchmarkContext context)
        {
            _counter = context.GetCounter("TestCounter");
        }

        [PerfBenchmark(Description = "Test to gauge the impact of having multiple things to measure on a benchmark.", 
            NumberOfIterations = 3, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestCounter", MustBe.GreaterThan, 10000000.0d)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        public void Benchmark()
        {
            _counter.Increment();
        }
        static int Main(string[] args)
        {
            return NBench.NBenchRunner.Run<Program>();
        }
    }
}
