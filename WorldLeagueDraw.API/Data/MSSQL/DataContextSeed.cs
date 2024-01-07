using System.Collections.Generic;
using WorldLeagueDraw.API.DTOs.Enums;
using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Data.MSSQL
{
    public static class DataContextSeed
    {
        public static void SeedData(DataContext _context)
        {
            int countryCount = _context.Countries.Count();
            if (countryCount <= 0)
            {
                _context.AddRange(PrepareCountryList());
                _context.SaveChanges();
            }

            var countries = _context.Countries.ToList();

            int teamsCount = _context.Teams.Count();
            if (teamsCount <= 0)
            {
                _context.AddRange(PrepareTeamList(countries));
                _context.SaveChanges();
            }
        }

        public static List<Country> PrepareCountryList()
        {
            return new List<Country>(){
                new Country()
                {
                    Id = 1,
                    Name = "Türkiye"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Almanya"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Fransa"
                },
                new Country()
                {
                    Id = 4,
                    Name = "Hollanda"
                },
                new Country()
                {
                    Id = 5,
                    Name = "Portekiz"
                },
                new Country()
                {
                    Id = 6,
                    Name = "İtalya"
                },
                new Country()
                {
                    Id = 7,
                    Name = "İspanya"
                },
                new Country()
                {
                    Id = 8,
                    Name = "Belçika"
                },
            };
        }

        public static List<Team> PrepareTeamList(List<Country> countries)
        {
            return new List<Team>(){
                #region Türkiye
                new Team()
                {
                    Name = "Adesso İstanbul",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Ankara",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso İzmir",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Antalya",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
	            #endregion
                #region Almanya
                new Team()
                {
                    Name = "Adesso Berlin",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Frankfurt",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Münih",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Dortmund",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
	            #endregion
                #region Fransa
                new Team()
                {
                    Name = "Adesso Paris",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Marsilya",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Nice",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Lyon",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
	            #endregion
                #region Hollanda
                new Team()
                {
                    Name = "Adesso Amsterdam",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Rotterdam",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Lahey",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Eindhoven",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
	            #endregion
                #region Portekiz
                new Team()
                {
                    Name = "Adesso Lisbon",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Porto",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Braga",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Coimbra",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
	            #endregion
                #region İtalya
                new Team()
                {
                    Name = "Adesso Roma",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Milano",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Venedik",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Napoli",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
	            #endregion
                #region İspanya
                new Team()
                {
                    Name = "Adesso Sevilla",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Madrid",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Barselona",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Granada",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
	            #endregion
                #region Belçika
                new Team()
                {
                    Name = "Adesso Brüksel",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Brugge",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Gent",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Anvers",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
	            #endregion
            };
        }
    }
}
