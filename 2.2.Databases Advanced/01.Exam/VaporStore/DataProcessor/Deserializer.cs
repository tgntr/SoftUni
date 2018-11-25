namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Import;

    public static class Deserializer
	{
        public const string ErrorMessage = "Invalid Data";

		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{
            var result = new StringBuilder();
            var importedDtos = JsonConvert.DeserializeObject<List<GameDto>>(jsonString);

            var validGames = new List<Game>();

            foreach (var gameDto in importedDtos)
            {
                if (!IsValid(gameDto))
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var tags = new List<GameTag>();

                var tagsAreValid = true;
                foreach (var tagDto in gameDto.Tags)
                {
                    if (string.IsNullOrEmpty(tagDto))
                    {
                        tagsAreValid = false;
                        break;
                    }

                    var tag = context.Tags.FirstOrDefault(t => t.Name == tagDto);

                    if (tag is null)
                    {
                        tag = new Tag
                        {
                            Name = tagDto
                        };

                        context.Tags.Add(tag);
                        context.SaveChanges();
                    }

                    var gameTag = new GameTag
                    {
                        Tag = tag
                    };

                    tags.Add(gameTag);
                }

                if (!tagsAreValid)
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var releaseDate = DateTime.ParseExact(gameDto.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                var developer = context.Developers.FirstOrDefault(d => d.Name == gameDto.Developer);

                if (developer is null)
                {
                    developer = new Developer
                    {
                        Name = gameDto.Developer
                    };

                    context.Developers.Add(developer);
                    context.SaveChanges();
                }

                var genre = context.Genres.FirstOrDefault(g => g.Name == gameDto.Genre);

                if (genre is null)
                {
                    genre = new Genre
                    {
                        Name = gameDto.Genre
                    };

                    context.Genres.Add(genre);
                    context.SaveChanges();
                }

                var game = new Game
                {
                    Name = gameDto.Name,
                    Price = gameDto.Price,
                    ReleaseDate = releaseDate,
                    Developer = developer,
                    Genre = genre,
                    GameTags = tags
                };

                validGames.Add(game);
                result.AppendLine($"Added {game.Name} ({game.Genre.Name}) with {game.GameTags.Count} tags");
            }

            context.Games.AddRange(validGames);
            context.SaveChanges();

            return result.ToString();
        }

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
            var result = new StringBuilder();
            var importedDtos = JsonConvert.DeserializeObject<List<UserDto>>(jsonString);

            var validUsers = new List<User>();

            foreach (var userDto in importedDtos)
            {
                if (!IsValid(userDto))
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var cards = new List<Card>();

                var cardsAreValid = true;

                foreach (var cardDto in userDto.Cards)
                {
                    if (!IsValid(cardDto) || !Enum.TryParse<CardType>(cardDto.Type, out CardType type))
                    {
                        cardsAreValid = false;
                        break;
                    }

                    var card = new Card
                    {
                        Number = cardDto.Number,
                        Cvc = cardDto.Cvc,
                        Type = type
                    };

                    cards.Add(card);
                }

                var user = new User
                {
                    FullName = userDto.FullName,
                    Username = userDto.Username,
                    Email = userDto.Email,
                    Age = userDto.Age,
                    Cards = cards
                };

                validUsers.Add(user);

                result.AppendLine($"Imported {user.Username} with {user.Cards.Count} cards");
            }

            context.AddRange(validUsers);
            context.SaveChanges();

            return result.ToString();
        }

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
            var serializer = new XmlSerializer(typeof(List<PurchaseDto>), new XmlRootAttribute("Purchases"));
            var importedDtos = (List<PurchaseDto>)serializer.Deserialize(new StringReader(xmlString));

            var result = new StringBuilder();

            var validPurchases = new List<Purchase>();

            foreach (var purchaseDto in importedDtos)
            {
                if (!IsValid(purchaseDto))
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                if (!Enum.TryParse<PurchaseType>(purchaseDto.Type, out PurchaseType type))
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var card = context.Cards.Include(c=>c.User).FirstOrDefault(c => c.Number == purchaseDto.Card);

                if (card is null)
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var date = DateTime.ParseExact(purchaseDto.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                var game = context.Games.FirstOrDefault(g => g.Name == purchaseDto.Game);

                if (game is null)
                {
                    result.AppendLine(ErrorMessage);
                    continue;
                }

                var purchase = new Purchase
                {
                    Type = type,
                    ProductKey = purchaseDto.Key,
                    Card = card,
                    Date = date,
                    Game = game
                };

                validPurchases.Add(purchase);

                result.AppendLine($"Imported {purchase.Game.Name} for {purchase.Card.User.Username}");
            }

            context.Purchases.AddRange(validPurchases);
            context.SaveChanges();

            return result.ToString();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResult, true);
        }
    }
}