namespace VaporStore.DataProcessor
{
	using System;
    using System.Linq;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;

    public static class Serializer
	{
		public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
		{
            var genres = context.Genres
                .Where(g => genreNames.Any(gn => gn == g.Name))
                .Include(g => g.Games)
                .Select(g => new
                {
                    Id = g.Id,
                    Genre = g.Name,
                    Games = g.Games
                        .Where(game => game.Purchases.Count > 0)
                        .Select(game => new
                        {
                            Id = game.Id,
                            Title = game.Name,
                            Developer = game.Developer.Name,
                            Tags = string.Join(", ", game.GameTags.Select(gt => gt.Tag.Name)),
                            Players = game.Purchases.Count()
                        })
                        .OrderByDescending(gg=>gg.Players)
                        .ThenBy(gg=>gg.Id)
                        .ToArray(),
                    TotalPlayers = g.Games.Sum(game => game.Purchases.Count())
                })
                .OrderByDescending(genre=>genre.TotalPlayers)
                .ThenBy(genre=>genre.Id)
                .ToArray();

            return JsonConvert.SerializeObject(genres, Newtonsoft.Json.Formatting.Indented);
        }

		public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
		{
			throw new NotImplementedException();
		}
	}
}