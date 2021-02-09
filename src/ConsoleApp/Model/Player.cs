namespace ConsoleApp.Model
{
    internal class Player
    {
        public string Id => LastName.ToLower();

        public string FirstName { get; init; } = string.Empty;

        public string LastName { get; init; } = string.Empty;

        public string? ClubId { get; init; }
    }
}
