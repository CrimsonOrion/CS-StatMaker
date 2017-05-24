using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_StatMaker
{
    public class Character
    {
        // Basic Information
        public string Name { get; set; }

        // Base stats
        public Stats BaseStats { get; set; }

        // Race
        public Race MyRace { get; set; }

        public Character(string eName, Stats eBaseStats, Race eMyRace)
        {
            Name = eName;
            BaseStats = eBaseStats;
            MyRace = eMyRace;
        }


    }

    public class Stats
    {
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Wisdom { get; set; } = 0;
        public int Charisma { get; set; } = 0;
        public int Additional { get; set; } = 0;
    }
}
            