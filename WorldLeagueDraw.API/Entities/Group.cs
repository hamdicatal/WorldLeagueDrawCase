namespace WorldLeagueDraw.API.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<Team> Teams { get; set; }
    }
}
