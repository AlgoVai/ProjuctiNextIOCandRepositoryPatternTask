using TeamsCrudOperation.Data;
using TeamsCrudOperation.DTO;
using TeamsCrudOperation.IRepository;

namespace TeamsCrudOperation.Repository
{
    public class TeamService :ITeamService
    {

        private readonly ApplicationDBContext _context;
        public TeamService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<TeamInfoDTO>> GetAllTeamsInfo()
        {
            try
            {
                var data = await Task.FromResult((from t in _context.TeamInfos
                                                  where t.TeamId > 0
                                                  select new TeamInfoDTO
                                                  {
                                                      TeamId = t.TeamId,
                                                      Description = t.Description,
                                                      ApprovedByManager = t.ApprovedByManager,
                                                      ApprovedByDirector = t.ApprovedByDirector,
                                                  }).ToList());
                                                   

                if(data == null)
                {
                    throw new Exception("Data not found!");
                }
                return data;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
