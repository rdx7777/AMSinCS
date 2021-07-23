namespace AMSinCS.ApplicationServices.API.Handlers
{
    using AMSinCS.ApplicationServices.API.Domain;
    using AMSinSC.DataAccess;
    using AMSinSC.DataAccess.Entities;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    class GetAbsenceCasesHandler : IRequestHandler<GetAbsenceCasesRequest, GetAbsenceCasesResponse>
    {
        private readonly IRepository<AbsenceCase> absenceCaseRepository;
        private readonly IRepository<User> userRepository;

        public GetAbsenceCasesHandler(IRepository<AMSinSC.DataAccess.Entities.AbsenceCase> absenceCaseRepository, 
            IRepository<AMSinSC.DataAccess.Entities.User> userRepository)
        {
            this.absenceCaseRepository = absenceCaseRepository;
            this.userRepository = userRepository;
        }

        public Task<GetAbsenceCasesResponse> Handle(GetAbsenceCasesRequest request, CancellationToken cancellationToken)
        {
            var absenceCases = this.absenceCaseRepository.GetAll();
            var domainAbsenceCases = absenceCases.Select(
                a => new Domain.Models.AbsenceCase()
            {
                Id = a.Id,
                User = MapToUserModels(a.User.Id),
                HeadTeacher = MapToUserModels(a.HeadTeacher.Id),
                CreatedDate = a.CreatedDate,
                StartDate = a.StartDate,
                EndDate = a.EndDate,
                PartDayType = a.PartDayType,
                AbsenceReason = a.AbsenceReason,
                UserComment = a.UserComment,
                IsCoverRequired = a.IsCoverRequired,
                IsCoverProvided = a.IsCoverProvided,
                CoverSupervisorComment = a.CoverSupervisorComment,
                IsApprovedByHeadTeacher = a.IsApprovedByHeadTeacher,
                IsAbsencePaid = a.IsAbsencePaid,
                HeadTeacherComment = a.HeadTeacherComment,
                HrSupervisorComment = a.HrSupervisorComment,
                IsCaseResolved = a.IsCaseResolved,
                ResolvedDate = a.ResolvedDate
                });

            var response = new GetAbsenceCasesResponse()
            {
                Data = domainAbsenceCases.ToList()
            };
            return Task.FromResult(response);
        }

        private Domain.Models.User MapToUserModels(int id)
        {
            var user = userRepository.GetById(id);

            var domainUser = new Domain.Models.User()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                JobTitle = user.JobTitle,
                Position = user.Position,
                Role = user.Role

            };

            return domainUser;
        }
    }
}
