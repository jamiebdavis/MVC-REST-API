using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Walk Dolly", Line = "Use Feet", Platform = "Tops" },
                new Command { Id = 1, HowTo = "Walk Etta", Line = "Use hands", Platform = "Park" },
                new Command { Id = 2, HowTo = "Walk Daisy", Line = "Use eyes", Platform = "Path" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Walk Dolly", Line = "Use Feet", Platform = "Tops" };
        }
    }
}
