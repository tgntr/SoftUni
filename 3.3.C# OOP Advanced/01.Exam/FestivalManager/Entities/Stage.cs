namespace FestivalManager.Entities
{
	using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using FestivalManager.Entities.Sets;

    public class Stage : IStage
    {
        private readonly List<ISet> sets = new List<ISet>();
        private readonly List<ISong> songs = new List<ISong>();
        private readonly List<IPerformer> performers = new List<IPerformer>();

        public IReadOnlyCollection<ISet> Sets => sets.AsReadOnly();

        public IReadOnlyCollection<ISong> Songs => songs.AsReadOnly();

        public IReadOnlyCollection<IPerformer> Performers => performers.AsReadOnly();

        public void AddSet(ISet set)
        {
            sets.Add(set);
        }

        public void AddPerformer(IPerformer performer)
        {
            performers.Add(performer);
        }

        public void AddSong(ISong song)
        {
            songs.Add(song);
        }
        
        public bool HasSet(string name)
        {
            return sets.Any(s => s.Name == name);
        }

        public bool HasPerformer(string name)
        {
            return performers.Any(p => p.Name == name);
        }

        public bool HasSong(string name)
        {
            return songs.Any(s => s.Name == name);
        }

        public IPerformer GetPerformer(string name)
        {
            var performer =  performers.Single(p => p.Name == name);
            

            return performer;

        }

        public ISong GetSong(string name)
        {
            var song = songs.Single(s => s.Name == name);
            

            return song;
        }

        public ISet GetSet(string name)
        {
            var set =  sets.Single(s => s.Name == name);
            
            return set;
        }
        
    }
}
