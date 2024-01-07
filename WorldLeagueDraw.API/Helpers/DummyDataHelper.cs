using WorldLeagueDraw.API.DTOs.Enums;
using WorldLeagueDraw.API.Entities;

namespace WorldLeagueDraw.API.Helpers
{
    public static class DummyDataHelper
    {
        public static List<Team> GetDummyTeamList()
        {
            return new List<Team>(){
                #region Türkiye
                new Team()
                {
                    Name = "Adesso İstanbul",
                    Country = "Türkiye",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Ankara",
                    Country = "Türkiye",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso İzmir",
                    Country = "Türkiye",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Antalya",
                    Country = "Türkiye",
                    CountryId =CountryEnum.Türkiye.GetHashCode()
                },
	            #endregion
                #region Almanya
                new Team()
                {
                    Name = "Adesso Berlin",
                    Country = "Almanya",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Frankfurt",
                    Country = "Almanya",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Münih",
                    Country = "Almanya",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Dortmund",
                    Country = "Almanya",
                    CountryId =CountryEnum.Almanya.GetHashCode()
                },
	            #endregion
                #region Fransa
                new Team()
                {
                    Name = "Adesso Paris",
                    Country = "Fransa",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Marsilya",
                    Country = "Fransa",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Nice",
                    Country = "Fransa",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Lyon",
                    Country = "Fransa",
                    CountryId =CountryEnum.Fransa.GetHashCode()
                },
	            #endregion
                #region Hollanda
                new Team()
                {
                    Name = "Adesso Amsterdam",
                    Country = "Hollanda",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Rotterdam",
                    Country = "Hollanda",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Lahey",
                    Country = "Hollanda",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Eindhoven",
                    Country = "Hollanda",
                    CountryId =CountryEnum.Hollanda.GetHashCode()
                },
	            #endregion
                #region Portekiz
                new Team()
                {
                    Name = "Adesso Lisbon",
                    Country = "Portekiz",
                    CountryId = CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Porto",
                    Country = "Portekiz",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Braga",
                    Country = "Portekiz",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Coimbra",
                    Country = "Portekiz",
                    CountryId =CountryEnum.Portekiz.GetHashCode()
                },
	            #endregion
                #region İtalya
                new Team()
                {
                    Name = "Adesso Roma",
                    Country = "İtalya",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Milano",
                    Country = "İtalya",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Venedik",
                    Country = "İtalya",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Napoli",
                    Country = "İtalya",
                    CountryId =CountryEnum.İtalya.GetHashCode()
                },
	            #endregion
                #region İspanya
                new Team()
                {
                    Name = "Adesso Sevilla",
                    Country = "İspanya",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Madrid",
                    Country = "İspanya",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Barselona",
                    Country = "İspanya",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Granada",
                    Country = "İspanya",
                    CountryId =CountryEnum.İspanya.GetHashCode()
                },
	            #endregion
                #region Belçika
                new Team()
                {
                    Name = "Adesso Brüksel",
                    Country = "Belçika",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Brugge",
                    Country = "Belçika",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Gent",
                    Country = "Belçika",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
                new Team()
                {
                    Name = "Adesso Anvers",
                    Country = "Belçika",
                    CountryId =CountryEnum.Belçika.GetHashCode()
                },
	            #endregion
            };
        }
    }
}
