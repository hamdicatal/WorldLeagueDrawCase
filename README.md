# WorldLeagueDraw
Uygulama dockerize olarak çalışmaktadır. "docker-compose up --build" komutuyla çalıştırılabilir.
Veritabanı olarak MongoDb kullanıldı. Default olarak 27017 portunda çalışmaktadır.
API tarafın .NET 7 kullanıldı. Default olarak :8000 portunda çalışmaktadır.

API'de sadece bir adet endpoint bulunmaktadır. Aşağıdaki adrese body içerisinde NameSurname ve GroupCount ile POST requesti atıldığında aşağıdaki gibi bir response dönmektedir.

http://localhost:8000/api/WorldLeagueDraw

{
  "groups": [
    {
      "groupName": "Group-A",
      "teams": [
        {
          "name": "Adesso Rotterdam"
        },
        {
          "name": "Adesso Marsilya"
        },
        {
          "name": "Adesso Gent"
        },
        {
          "name": "Adesso Milano"
        }
      ]
    },
    {
      "groupName": "Group-B",
      "teams": [
        {
          "name": "Adesso Amsterdam"
        },
        {
          "name": "Adesso Paris"
        },
        {
          "name": "Adesso Brugge"
        },
        {
          "name": "Adesso Napoli"
        }
      ]
    },
    {
      "groupName": "Group-C",
      "teams": [
        {
          "name": "Adesso Lahey"
        },
        {
          "name": "Adesso Nice"
        },
        {
          "name": "Adesso Anvers"
        },
        {
          "name": "Adesso Venedik"
        }
      ]
    },
    {
      "groupName": "Group-D",
      "teams": [
        {
          "name": "Adesso Eindhoven"
        },
        {
          "name": "Adesso Lyon"
        },
        {
          "name": "Adesso Brüksel"
        },
        {
          "name": "Adesso Roma"
        }
      ]
    },
    {
      "groupName": "Group-E",
      "teams": [
        {
          "name": "Adesso Lisbon"
        },
        {
          "name": "Adesso İzmir"
        },
        {
          "name": "Adesso Barselona"
        },
        {
          "name": "Adesso Berlin"
        }
      ]
    },
    {
      "groupName": "Group-F",
      "teams": [
        {
          "name": "Adesso Coimbra"
        },
        {
          "name": "Adesso Antalya"
        },
        {
          "name": "Adesso Madrid"
        },
        {
          "name": "Adesso Münih"
        }
      ]
    },
    {
      "groupName": "Group-G",
      "teams": [
        {
          "name": "Adesso Porto"
        },
        {
          "name": "Adesso Ankara"
        },
        {
          "name": "Adesso Sevilla"
        },
        {
          "name": "Adesso Frankfurt"
        }
      ]
    },
    {
      "groupName": "Group-H",
      "teams": [
        {
          "name": "Adesso Braga"
        },
        {
          "name": "Adesso İstanbul"
        },
        {
          "name": "Adesso Granada"
        },
        {
          "name": "Adesso Dortmund"
        }
      ]
    }
  ]
}
