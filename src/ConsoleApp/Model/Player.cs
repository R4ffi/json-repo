using System;

namespace ConsoleApp.Model
{
    internal class Player
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string FirstName { get; init; } = string.Empty;

        public string LastName { get; init; } = string.Empty;

        public Guid? ClubId { get; init; }
    }
}
