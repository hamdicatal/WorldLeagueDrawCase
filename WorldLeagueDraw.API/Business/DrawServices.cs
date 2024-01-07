using WorldLeagueDraw.API.Business.Interfaces;
using WorldLeagueDraw.API.DTOs;
using WorldLeagueDraw.API.Entities;
using WorldLeagueDraw.API.Repositories.Interfaces;

namespace WorldLeagueDraw.API.Business
{
    public class DrawServices : IDrawServices
    {
        private readonly IDrawRepository _repository;
        public DrawServices(IDrawRepository drawRepository)
        {
            _repository = drawRepository;
        }

        public async Task<DrawResponseDTO> Draw(DrawRequestDTO request)
        {
            // get all teams from database
            var teams = await _repository.GetAllTeams(); 

            // prepare teams dictionary based on country
            var countryTeams = PrepareCountryTeams(teams.ToList());

            // handle draw operations
            var groups = PrepareGroups(countryTeams, request.GroupCount);

            // create and save draw result to db
            var drawResult = new DrawResult();
            drawResult.NameSurname = request.NameSurname;
            drawResult.Groups = groups.Select(x => new Group()
            {
                GroupName = x.Key,
                Teams = x.Value.Select(y => new Team() { Name = y.Name, Country = y.Country }).ToList()
            }).ToList();

            await _repository.CreateDrawResult(drawResult);

            return new DrawResponseDTO()
            {
                Groups = groups.Select(x => new GroupDTO()
                {
                    GroupName = x.Key,
                    Teams = x.Value.Select(y => new TeamDTO() { Name = y.Name }).ToList(),
                }).ToList(),
            };
        }

        private static Dictionary<string, List<Team>> PrepareGroups(Dictionary<string, List<Team>> countryTeams, int groupCount)
        {
            Random random = new Random();
            List<Team> selectedTeams = new List<Team>();
            Dictionary<string, List<Team>> groups = new Dictionary<string, List<Team>>();
            char[] groupLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            // shuffle teams list:
            countryTeams = countryTeams.OrderBy(x => random.Next()).ToDictionary(item => item.Key, item => item.Value);

            if (groupCount == 4)
            {
                for (int i = 0; i < groupCount; i++)
                {
                    foreach (var country in countryTeams.Keys)
                    {
                        int tmpCount = countryTeams[country].Count;

                        if (tmpCount <= 0)
                            continue;

                        int randomIndex = random.Next(tmpCount);
                        var temp = countryTeams[country][randomIndex];
                        selectedTeams.Add(temp);
                        countryTeams[country].Remove(temp);
                    }
                    string groupName = "Group-" + groupLetters[i];
                    if (!groups.ContainsKey(groupName))
                        groups[groupName] = new List<Team>();
                    groups[groupName].AddRange(selectedTeams);
                    selectedTeams.Clear();
                }
            }
            else if (groupCount == 8)
            {
                for (int i = 0; i < groupCount; i++)
                {
                    int limit = 0;
                    foreach (var country in countryTeams.Keys)
                    {
                        if (limit >= 4)
                            break;

                        int tmpCount = countryTeams[country].Count;

                        if (tmpCount <= 0)
                            continue;

                        int randomIndex = random.Next(tmpCount);
                        var temp = countryTeams[country][randomIndex];
                        selectedTeams.Add(temp);
                        countryTeams[country].Remove(temp);
                        limit++;
                    }
                    string groupName = "Group-" + groupLetters[i];
                    if (!groups.ContainsKey(groupName))
                        groups[groupName] = new List<Team>();
                    groups[groupName].AddRange(selectedTeams);
                    selectedTeams.Clear();
                }
            }

            return groups;
        }

        private static Dictionary<string, List<Team>> PrepareCountryTeams(List<Team> teams)
        {
            Dictionary<string, List<Team>> countryTeams = new Dictionary<string, List<Team>>();
            foreach (Team team in teams)
            {
                if (!countryTeams.ContainsKey(team.Country))
                    countryTeams[team.Country] = new List<Team>();

                countryTeams[team.Country].Add(team);
            }

            return countryTeams;
        }
    }
}
