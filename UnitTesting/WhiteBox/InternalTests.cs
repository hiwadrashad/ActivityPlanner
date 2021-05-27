using ActivityPlannerBlazor.Client.DataService;
using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace UnitTesting.WhiteBox
{
    public class InternalTests
    {
        AppointmentDTO appointment = new AppointmentDTO()
        {
            AcceptanceRate = 12,
            ApproximateDate = ActivityPlannerBlazor.Shared.Enums.Season.Autumn,
            AcceptedOrNot = new List<Tuple<AttendeeDTO, bool>>()
            { },
            Attendees = new List<AttendeeDTO>()
            { },
            Category = ActivityPlannerBlazor.Shared.Enums.Category.Diner,
            Description = "",
            EndDate = DateTime.Now,
            id = Guid.NewGuid().ToString(),
            Location = "",
            MainOrganizer = new OrganizerDTO()
            { },
            Name = "",
            Organizers = new List<OrganizerDTO>()
            { },
            StartDate = DateTime.Now
        };

        OrganizerDTO organizer = new OrganizerDTO()
        {
            Acquaintances = new List<AttendeeDTO>()
            { },
            Appointments = new List<AppointmentDTO>()
            { },
            Data = new PersonalDataDTO()
            { },
            id = Guid.NewGuid().ToString(),
            Messages = new List<MessageDTO>()
            { },
            PassedAcceptanceRateAppointments = new List<AppointmentDTO>()
            { }
        };

        AttendeeDTO attendee = new AttendeeDTO()
        {
            AcceptedInvites = new List<AcceptedInviteDTO>()
            { },
            Data = new PersonalDataDTO()
            { },
            id = Guid.NewGuid().ToString(),
            NotAcceptedInvites = new List<NotAcceptedInviteDTO>()
            { },
            PendingInvites = new List<PendingInviteDTO>()
            { },
            Updates = new List<string>()
            { }
        };

        private IAppointmentDataService _appointment { get; set; }
        private IAttendeeDataService _attendee { get; set; }
        private IOrganizerDataService _organizer { get; set; }
        private Uri uri = new Uri("https://localhost:44333/");

        public void AppointmentDependencyInjection()
        {
            if (_appointment == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IAppointmentDataService, AppointmentDataService>(client =>
                {
                    client.BaseAddress = uri;
                });

                var serviceprovider = services.BuildServiceProvider();
                _appointment = serviceprovider.GetService<IAppointmentDataService>();
            }
        }

        public void AttendeeDependencyInjection()
        {
            if (_attendee == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IAttendeeDataService, AttendeeDataService>(client =>
                {
                    client.BaseAddress = uri;
                });

                var serviceprovider = services.BuildServiceProvider();
                _appointment = serviceprovider.GetService<IAppointmentDataService>();
            }
        }

        public void OrganizerDependencyInjection()
        {
            if (_organizer == null)
            {
                var services = new ServiceCollection();
                services.AddHttpClient<IOrganizerDataService, OrganizerDataService>(client =>
                {
                    client.BaseAddress = uri;
                });

                var serviceprovider = services.BuildServiceProvider();
                _organizer = serviceprovider.GetService<IOrganizerDataService>();
            }
        }

        [Test]
        [Category("Adding")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddAppointment()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AppointmentDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _appointment.Add(appointment));
        }

        [Test]
        [Category("Adding")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddAttendee()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AttendeeDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _attendee.Add(attendee));
        }

        [Test]
        [Category("Adding")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddOrganizer()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            OrganizerDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _organizer.Add(organizer));
        }

        [Test]
        [Category("Delete")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task DeleteAppointment()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AppointmentDependencyInjection();
            await _appointment.Add(appointment);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _appointment.Delete(appointment.id));
            var allappointments = await _appointment.GetAll();
            if (allappointments.Contains(appointment))
            {
               await  _appointment.Delete(appointment.id);
            }
        }
        [Test]
        [Category("Delete")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task DeleteAttendee()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AttendeeDependencyInjection();
            await _attendee.Add(attendee);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _attendee.Delete(attendee.id));
            var allattendees = await _attendee.GetAll();
            if (allattendees.Contains(attendee))
            {
                await _attendee.Delete(attendee.id);
            }
        }

        [Test]
        [Category("Delete")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task DeleteOrganizer()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            OrganizerDependencyInjection();
            await _organizer.Add(organizer);
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _organizer.Delete(organizer.id));
            var allorganizer = await _organizer.GetAll();
            if (allorganizer.Contains(organizer))
            {
                await _organizer.Delete(organizer.id);
            }
        }

        [Test]
        [Category("Edit")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task EditAppointment()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AppointmentDependencyInjection();
            await _appointment.Add(appointment);
            appointment.Name = "Unit Tested";
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _appointment.Update(appointment));
            var allappointments = await _appointment.GetAll();
            if (allappointments.Contains(appointment))
            {
                await _appointment.Delete(appointment.id);
            }
            appointment.Name = "";
        }

        [Test]
        [Category("Edit")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task EditAttendee()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AttendeeDependencyInjection();
            await _attendee.Add(attendee);
            attendee.Data.Name = "Unit Tested";
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _attendee.Update(attendee));
            var allattendees = await _attendee.GetAll();
            if (allattendees.Contains(attendee))
            {
                await _attendee.Delete(attendee.id);
            }
            attendee.Data.Name = "";
        }

        [Test]
        [Category("Edit")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task EditOrganizer()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            OrganizerDependencyInjection();
            await _organizer.Add(organizer);
            organizer.Data.Name = "Unit Tested";
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _organizer.Update(organizer));
            var allorganizers = await _organizer.GetAll();
            if (allorganizers.Contains(organizer))
            {
                await _organizer.Delete(organizer.id);
            }
            organizer.Data.Name = "";
        }

        [Test]
        [Category("Get")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAppointment()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AppointmentDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _appointment.GetDetails(appointment.id));

        }

        [Test]
        [Category("Get")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task GetAttendee()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            AttendeeDependencyInjection();
            NUnit.Framework.Assert.DoesNotThrowAsync(async () => await _attendee.GetDetails(attendee.id));

        }
    }
}
