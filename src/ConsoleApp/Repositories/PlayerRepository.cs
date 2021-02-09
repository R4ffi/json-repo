using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ConsoleApp.Model;

namespace ConsoleApp.Repositories
{
    internal class PlayerRepository
    {
        private const string rootFolder = "C:/temp/players";

        public void Add(Player player)
        {
            var fileName = GetFileNameById(player.Id);
            if (File.Exists(fileName))
            {
                throw new Exception("Player already exists!");
            }

            var jsonString = JsonSerializer.Serialize(player);
            File.WriteAllText(fileName, jsonString);
        }

        public void Update(Player player)
        {
            var fileName = GetFileNameById(player.Id);
            if (!File.Exists(fileName))
            {
                throw new Exception("Player not found!");
            }

            var jsonString = JsonSerializer.Serialize(player);
            File.WriteAllText(fileName, jsonString);
        }

        public void Delete(string id)
        {
            var fileName = GetFileNameById(id);
            if (!File.Exists(fileName))
            {
                throw new Exception("Player not found!");
            }

            File.Delete(fileName);
        }

        public Player GetById(string id)
        {
            Player? player = null;

            var fileName = GetFileNameById(id);
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                player = JsonSerializer.Deserialize<Player>(json);
            }

            return player ?? throw new Exception("Player not found!");
        }

        public IEnumerable<Player> GetByIds(params string[] ids)
        {
            foreach (var id in ids)
            {
                var fileName = GetFileNameById(id);
                var json = File.ReadAllText(fileName);
                var player = JsonSerializer.Deserialize<Player>(json);

                if (player != null)
                {
                    yield return player;
                }
            }
        }

        public IEnumerable<Player> GetAll()
        {
            foreach (var fileName in Directory.GetFiles(rootFolder))
            {
                var json = File.ReadAllText(fileName);
                var player = JsonSerializer.Deserialize<Player>(json);

                if (player != null)
                {
                    yield return player;
                }
            }
        }

        private static string GetFileNameById(string id) => $"{rootFolder}/{id}.json";
    }
}
