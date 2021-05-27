using NBench;
using System;

namespace StressTestExecution
{
    class Program
    {
        private Counter _opCounter;

        [PerfSetup]
        public void Setup(BenchmarkContext context)
        {
            _opCounter = context.GetCounter("MyCounter");
        }

        [PerfBenchmark(NumberOfIterations = 13, RunMode = RunMode.Throughput, RunTimeMilliseconds = 1000, TestMode = TestMode.Measurement)]
        [CounterMeasurement("MyCounter")]
        [MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]

        public void BenchMarkMethod(BenchmarkContext context)
        {
            var bytes = new byte[1024];
            _opCounter.Increment();

        }
        static int Main(string[] args)
        {
            return NBench.NBenchRunner.Run<Program>();
        }
    }
}
