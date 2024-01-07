namespace WorldLeagueDraw.API.Entities
{
    public class DrawResult
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public List<Group> Groups { get; set; }
    }
}
