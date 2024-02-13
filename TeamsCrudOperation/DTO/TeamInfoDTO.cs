namespace TeamsCrudOperation.DTO
{
    public class TeamInfoDTO
    {

       
        public long TeamId { get; set; }
     
        public string TeamName { get; set; }
        public string Description { get; set; }
        public int ApprovedByManager { get; set; }
        public int ApprovedByDirector { get; set; }

    }
}
