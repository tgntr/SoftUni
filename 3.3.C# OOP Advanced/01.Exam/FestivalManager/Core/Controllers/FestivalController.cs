namespace FestivalManager.Core.Controllers
{
	using System;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Contracts;
	using Entities.Contracts;
    using FestivalManager.Entities.Factories;
    using FestivalManager.Entities.Factories.Contracts;

    public class FestivalController : IFestivalController
	{
        
		private const string TimeFormat = "mm\\:ss";
		private const string TimeFormatLong = "{0:2D}:{1:2D}";
		private const string TimeFormatThreeDimensional = "{0:3D}:{1:3D}";

		private readonly IStage stage;

        private SetFactory setFactory = new SetFactory();
        private PerformerFactory performerFactory = new PerformerFactory();
        private SongFactory songFactory = new SongFactory();
        private InstrumentFactory instrumentFactory = new InstrumentFactory();
        

		public FestivalController(IStage stage)
		{
			this.stage = stage;
		}

		public string ProduceReport()
		{
			var result = string.Empty;

			var totalFestivalLength = new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));

			result += ($"Festival length: {FormatTime(totalFestivalLength)}") + "\n";

			foreach (var set in this.stage.Sets)
			{
				result += ($"--{set.Name} ({FormatTime(set.ActualDuration)}):") + "\n";

				var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);
				foreach (var performer in performersOrderedDescendingByAge)
				{
					var instruments = string.Join(", ", performer.Instruments
						.OrderByDescending(i => i.Wear));

					result += ($"---{performer.Name} ({instruments})") + "\n";
				}

				if (!set.Songs.Any())
					result += ("--No songs played") + "\n";
				else
				{
					result += ("--Songs played:") + "\n";
					foreach (var song in set.Songs)
					{
						result += ($"----{song.Name} ({song.Duration.ToString(TimeFormat)})") + "\n";
					}
				}
			}

			return result.ToString();
		}

        private string FormatTime(TimeSpan duration)
        {
            
            var result = $"{(duration.Minutes + duration.Hours * 60):D2}:{duration.Seconds:D2}";

            return result;
        }

        public string RegisterSet(string[] args)
		{
            var name = args[0];
            var type = args[1];
            stage.AddSet(setFactory.CreateSet(name, type));
            return String.Format(OutputMessages.RegisteredSet, type);
		}

		public string SignUpPerformer(string[] args)
		{
			var name = args[0];
			var age = int.Parse(args[1]);

			var instruments = args.Skip(2).Select(i => this.instrumentFactory.CreateInstrument(i))
				.ToArray();

			var performer = this.performerFactory.CreatePerformer(name, age);

			foreach (var instrument in instruments)
			{
				performer.AddInstrument(instrument);
			}

			this.stage.AddPerformer(performer);

            return String.Format(OutputMessages.RegisteredPerformer, name);
		}

		public string RegisterSong(string[] args)
		{
            var name = args[0];
            var length = args[1].Split(":").Select(int.Parse).ToArray();
            var minutes = length[0];
            var seconds = length[1];

            var duration = new TimeSpan(0, minutes, seconds);

            var song = songFactory.CreateSong(name, duration);
            stage.AddSong(song);

            return String.Format(OutputMessages.RegisteredSong, song);
        }

        public string AddSongToSet(string[] args)
		{
			var songName = args[0];
			var setName = args[1];

            
			if (!this.stage.HasSong(songName))
			{
				throw new InvalidOperationException(OutputMessages.InvalidSongProvided);
			}

			if (!this.stage.HasSet(setName))
			{
				throw new InvalidOperationException(OutputMessages.InvalidSetProvided);
			}


			var set = this.stage.GetSet(setName);
			var song = this.stage.GetSong(songName);

			set.AddSong(song);

			return String.Format(OutputMessages.AddedSongToSet, song, set.Name);
		}
        
		public string AddPerformerToSet(string[] args)
		{
            var performerName = args[0];
            var setName = args[1];
            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidPerformerProvided);
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidSetProvided);
            }

            

            var set = this.stage.GetSet(setName);
            var performer = this.stage.GetPerformer(performerName);

            set.AddPerformer(performer);

            return String.Format(OutputMessages.AddedPerformerToSet, performerName, setName);
        }

		public string RepairInstruments(string[] args)
		{
			var instrumentsToRepair = this.stage.Performers
				.SelectMany(p => p.Instruments)
				.Where(i => i.Wear < 100)
				.ToArray();

			foreach (var instrument in instrumentsToRepair)
			{
				instrument.Repair();
			}

			return $"Repaired {instrumentsToRepair.Length} instruments";
		}

    }
}