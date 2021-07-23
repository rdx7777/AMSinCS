using AMSinCS.ApplicationServices.API.Domain;
using AMSinSC.DataAccess;
using AMSinSC.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AMSinCS.Controllers
{
    [ApiController]
    [Route("/api/cases")]
    public class AbsenceCasesController : ControllerBase
    {
        private readonly IMediator mediator;

        public AbsenceCasesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("/all_cases")]
        public async Task<IActionResult> GetAllAbsenceCases([FromQuery] GetAbsenceCasesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        //[HttpGet]
        //[Route("/{absenceCaseId}")]
        //public AbsenceCase GetAbsenceCaseById(int absenceCaseId) => this.abcenceCaseRepository.GetById(absenceCaseId);
    }
}
