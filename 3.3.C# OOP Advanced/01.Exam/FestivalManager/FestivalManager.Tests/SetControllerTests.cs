// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to your project (entities/controllers/etc)
namespace FestivalManager.Tests
{
  //using FestivalManager.Core.Controllers;
  //using FestivalManager.Entities;
  //using FestivalManager.Entities.Factories;
  //using FestivalManager.Entities.Instruments;
  //using FestivalManager.Entities.Sets;
    using NUnit.Framework;
    //using System;

    [TestFixture]
	public class SetControllerTests
    {
		[Test]
	    public void Test()
	    {
            var stage = new Stage();
            stage.AddSet(new Medium(nameof(Medium)));
            stage.AddSet(new Long(nameof(Long)));

            var songName = "song1";
            var mediumSet = nameof(Medium);
            var longSet = nameof(Long);

            var performer = new Performer("performer", 22);
            var guitar = new Guitar();
            performer.AddInstrument(guitar);

            var song = new Song(songName, new System.TimeSpan(0, 2, 22));
            stage.AddSong(song);
            var set = stage.GetSet(mediumSet);
            set.AddSong(song);
            set.AddPerformer(performer);



            var setController = new SetController(stage);
            var result = setController.PerformSets().Split(System.Environment.NewLine);
            Assert.IsTrue(result[0] == "1. Medium:");

            Assert.IsTrue(result[2].Contains("Successful"));

            Assert.IsTrue(result[4].Contains("Did not perform"));

            Assert.That(guitar.Wear, Is.EqualTo(40));

        }

        [Test]
        
        public void Test2()
        {
            var stage = new Stage();
            stage.AddSet(new Medium(nameof(Medium)));

            var songName = "song1";
            var mediumSet = nameof(Medium);

            var performer = new Performer("performer", 22);
            var guitar = new Guitar();
            performer.AddInstrument(guitar);

            var song = new Song(songName, new System.TimeSpan(0, 2, 22));
            stage.AddSong(song);
            var set = stage.GetSet(mediumSet);
            set.AddSong(song);
            set.AddSong(song);
            set.AddSong(song);
            set.AddSong(song);
            set.AddSong(song);
            set.AddPerformer(performer);



            var setController = new SetController(stage);
            var result = setController.PerformSets().Split(System.Environment.NewLine);

            
        }
	}
}