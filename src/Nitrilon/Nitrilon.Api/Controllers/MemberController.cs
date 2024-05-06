using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Nitrilon.DataAccess;
using Nitrilon.Entities;

namespace Nitrilon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetAll()
        {
            MemberRepository memberRepository = new();
            List<Member> all = memberRepository.GetAllMembers();
            return all;
        }
    }
}
