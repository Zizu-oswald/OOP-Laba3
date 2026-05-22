namespace FootballApi.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public List<Player>? Players { get; set; }
    }
}
