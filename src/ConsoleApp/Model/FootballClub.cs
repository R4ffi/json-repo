using System;

namespace ConsoleApp.Model
{
    internal class FootballClub
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string Name { get; init; } = string.Empty;

        public string City { get; init; } = string.Empty;
    }
}
