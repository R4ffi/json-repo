namespace ConsoleApp.Model
{
    internal class FootballClub
    {
        public string Id => Name.ToLower();

        public string Name { get; init; } = string.Empty;

        public string City { get; init; } = string.Empty;
    }
}
