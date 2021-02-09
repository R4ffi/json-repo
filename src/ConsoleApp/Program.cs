using ConsoleApp.Model;
using ConsoleApp.Repositories;

namespace ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            FootballClub juve = new()
            {
                Name = "Juventus Football Club",
                City = "Torino"
            };
            FootballClub barca = new()
            {
                Name = "Futbol Club Barcelona",
                City = "Barcelona"
            };

            Player messi = new()
            {
                LastName = "Messi",
                FirstName = "Lionel",
                ClubId = barca.Id
            };

            Player ronaldo = new()
            {
                LastName = "Ronaldo",
                FirstName = "Cristiano",
                ClubId = juve.Id
            };

            Player buffon = new()
            {
                LastName = "Buffon",
                FirstName = "Gianluigi",
                ClubId = juve.Id
            };

            var repo = new PlayerRepository();

            repo.Add(messi);
            repo.Add(ronaldo);
            repo.Add(buffon);
        }
    }
}
