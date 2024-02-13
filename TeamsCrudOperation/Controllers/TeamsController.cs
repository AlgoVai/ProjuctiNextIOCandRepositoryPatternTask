using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeamsCrudOperation.IRepository;

namespace TeamsCrudOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {

        private readonly ITeamService _teamService;
        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpGet]
        [Route("GetAllTeamsInfo")]
        public async Task<IActionResult> GetAllTeamsInfo()
        {
            return Ok(JsonConvert.SerializeObject(await _teamService.GetAllTeamsInfo()));
        }
    }
}
