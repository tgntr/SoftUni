
using System;
using System.Linq;
namespace FestivalManager.Core
{
	using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using IO.Contracts;

	/// <summary>
	/// by g0shk0
	/// </summary>
	class Engine : IEngine
	{
        private IReader reader = new ConsoleReader();
        private IWriter writer = new ConsoleWriter();
        
        private IFestivalController festivalCоntroller;
        private ISetController setController;

        public Engine(IFestivalController festivalController, ISetController setController)
        {
            this.festivalCоntroller = festivalController;
            this.setController = setController;

        }
        
		public void Run()
		{
			while (true)
			{
				var input = reader.ReadLine();

				if (input == "END")
					break;

				try
				{
					var result = this.ProcessCommand(input);
					this.writer.WriteLine(result);
				}
				catch (Exception ex) 
				{
					this.writer.WriteLine("ERROR: " + ex.Message);
				}
			}

            var end = festivalCоntroller.ProduceReport();

			this.writer.WriteLine("Results:");
			this.writer.WriteLine(end);
		}

		public string ProcessCommand(string input)
		{
            var details = input.Split();

			var command = details.First();
			var parameters = details.Skip(1).ToArray();

			if (command == "LetsRock")
			{
                return setController.PerformSets();
			}
            
			var festivalControlFunction = festivalCоntroller.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == command);

            var output = "";

			try
			{
				output = (string)festivalControlFunction.Invoke(this.festivalCоntroller, new object[] { parameters });
			}
			catch (TargetInvocationException ex)
			{
                output = "ERROR: " + ex.InnerException.Message;
            }

            return output;
		}
        
    }
}