using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IMockingRepo _repo = MockingRepo.GetMockingRepo();
            var item = _repo.GetAllOrganizers();
            Console.WriteLine(item.Count);
        }
    }
}
