namespace AMSinCS.ApplicationServices.API.Handlers
{
    using AMSinCS.ApplicationServices.API.Domain;
    using AMSinSC.DataAccess;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        private readonly IRepository<AMSinSC.DataAccess.Entities.User> userRepository;

        public GetUsersHandler(IRepository<AMSinSC.DataAccess.Entities.User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = this.userRepository.GetAll();
            var domainUsers = users.Select(u => new Domain.Models.User()
            {
                Id = u.Id,
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Email,
                JobTitle = u.JobTitle,
                Position = u.Position,
                Role = u.Role
            });

            var response = new GetUsersResponse()
            {
                Data = domainUsers.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
