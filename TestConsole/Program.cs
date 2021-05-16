using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using System;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IMockingRepo _repo = MockingRepo.GetMockingRepo();
            var item = _repo.GetAllOrganizers().FirstOrDefault();
            item.Appointments.Add(new ActivityPlannerBlazor.Shared.DTOS.AppointmentDTO() { });
            _repo.UpdateOrganizer(item);
            var item2 = _repo.GetAllOrganizers().Where(a => a.id == item.id).FirstOrDefault();
            Console.WriteLine(item2.Appointments.Count);
        }
    }
}
