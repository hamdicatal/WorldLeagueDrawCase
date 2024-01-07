﻿using WorldLeagueDraw.API.DTOs.Enums;
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
                    Country = "Türkiye"
                },
                new Team()
                {
                    Name = "Adesso Ankara",
                    Country = "Türkiye"
                },
                new Team()
                {
                    Name = "Adesso İzmir",
                    Country = "Türkiye"
                },
                new Team()
                {
                    Name = "Adesso Antalya",
                    Country = "Türkiye"
                },
	            #endregion
                #region Almanya
                new Team()
                {
                    Name = "Adesso Berlin",
                    Country = "Almanya"
                },
                new Team()
                {
                    Name = "Adesso Frankfurt",
                    Country = "Almanya"
                },
                new Team()
                {
                    Name = "Adesso Münih",
                    Country = "Almanya"
                },
                new Team()
                {
                    Name = "Adesso Dortmund",
                    Country = "Almanya"
                },
	            #endregion
                #region Fransa
                new Team()
                {
                    Name = "Adesso Paris",
                    Country = "Fransa"
                },
                new Team()
                {
                    Name = "Adesso Marsilya",
                    Country = "Fransa"
                },
                new Team()
                {
                    Name = "Adesso Nice",
                    Country = "Fransa"
                },
                new Team()
                {
                    Name = "Adesso Lyon",
                    Country = "Fransa"
                },
	            #endregion
                #region Hollanda
                new Team()
                {
                    Name = "Adesso Amsterdam",
                    Country = "Hollanda"
                },
                new Team()
                {
                    Name = "Adesso Rotterdam",
                    Country = "Hollanda"
                },
                new Team()
                {
                    Name = "Adesso Lahey",
                    Country = "Hollanda"
                },
                new Team()
                {
                    Name = "Adesso Eindhoven",
                    Country = "Hollanda"
                },
	            #endregion
                #region Portekiz
                new Team()
                {
                    Name = "Adesso Lisbon",
                    Country = "Portekiz"
                },
                new Team()
                {
                    Name = "Adesso Porto",
                    Country = "Portekiz"
                },
                new Team()
                {
                    Name = "Adesso Braga",
                    Country = "Portekiz"
                },
                new Team()
                {
                    Name = "Adesso Coimbra",
                    Country = "Portekiz"
                },
	            #endregion
                #region İtalya
                new Team()
                {
                    Name = "Adesso Roma",
                    Country = "İtalya"
                },
                new Team()
                {
                    Name = "Adesso Milano",
                    Country = "İtalya"
                },
                new Team()
                {
                    Name = "Adesso Venedik",
                    Country = "İtalya"
                },
                new Team()
                {
                    Name = "Adesso Napoli",
                    Country = "İtalya"
                },
	            #endregion
                #region İspanya
                new Team()
                {
                    Name = "Adesso Sevilla",
                    Country = "İspanya"
                },
                new Team()
                {
                    Name = "Adesso Madrid",
                    Country = "İspanya"
                },
                new Team()
                {
                    Name = "Adesso Barselona",
                    Country = "İspanya"
                },
                new Team()
                {
                    Name = "Adesso Granada",
                    Country = "İspanya"
                },
	            #endregion
                #region Belçika
                new Team()
                {
                    Name = "Adesso Brüksel",
                    Country = "Belçika"
                },
                new Team()
                {
                    Name = "Adesso Brugge",
                    Country = "Belçika"
                },
                new Team()
                {
                    Name = "Adesso Gent",
                    Country = "Belçika"
                },
                new Team()
                {
                    Name = "Adesso Anvers",
                    Country = "Belçika"
                },
	            #endregion
            };
        }
    }
}
