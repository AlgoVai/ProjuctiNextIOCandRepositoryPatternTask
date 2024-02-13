using Microsoft.AspNetCore.Mvc;
using TeamsCrudOperation.DTO;

namespace TeamsCrudOperation.IRepository
{
    public interface ITeamService
    {

        public Task<List<TeamInfoDTO>> GetAllTeamsInfo();
    }
}
