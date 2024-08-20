using System;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace AdMunitorumCharacterCreatorForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of your Form1 (AdMunitorumCharacterCreatorForm)
            Form1 adMunitorumCharacterCreatorForm = new Form1();


            // Run the main application loop
            Application.Run(adMunitorumCharacterCreatorForm);
        }
        static int GenerateD100()
        {
            // Get the current epoch time in milliseconds
            long epochTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            // Use the epoch time as the seed for the random number generator
            Random random = new Random((int)epochTime);

            // Generate a random number between 1 and 100
            int randomNumber = random.Next(1, 101);

            return randomNumber;
        }
    }
    public class StatsSingleton //this represents the source of truth for all stats 
    {
        private static StatsSingleton _instance;

        public static StatsSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StatsSingleton();
                }

                return _instance;
            }
        }
        //characteristics
        public int WeaponSkill { get; set; }
        public int BallisticsSkill { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Perception { get; set; }
        public int Willpower { get; set; }
        public int Fellowship { get; set; }

        //other stats
        public int EXP { get; set; }
        public int Solars { get; set; }

        public Dictionary<string, string> TalentDict { get; set; } //Does this need to be something else?

        public OriginList AllOrigins { get; set; }

        public Origin PreviousOrigin { get; set; } //for use in reverting advances.
        public Origin CurrentOrigin { get; set; } //Currently selected origin
        public FactionList AllFactions { get; set; }
        public List<int> AllStatAdvances { get; set; }
        public List<int> AllSkillAdvances { get; set; }
        public Dictionary<string, int> AllSpecializations { get; set; }

        public Duty CurrentDuty { get; set; } //Currently selected duty
        public Duty PreviousDuty { get; set; } //for use in reverting advances.

        public Faction CurrentFaction { get; set; } //Currently selected faction
        public Faction PreviousFaction { get; set; } //for use in reverting advances.

        public enum SkillEnum
        {
            Athletics,
            Awareness,
            Dexterity,
            Discipline,
            Fortitude,
            Intuition,
            Linguistics,
            Logic,
            Lore,
            Medicae,
            Melee,
            Navigation,
            Presence,
            Piloting,
            PsychicMastery,
            Ranged,
            Rapport,
            Reflexes,
            Stealth,
            Tech
        }

        public enum StatsEnum
        {
            WeaponSkill,
            BallisticsSkill,
            Strength,
            Toughness,
            Agility,
            Intelligence,
            Perception,
            Willpower,
            Fellowship
        }

        //skills
        /*
         * Athletics (Str)
         * Awareness (Per)
         * Dexerity (Agi)
         * Dicipline (Will)
         * Fortitude (Tgh)
         * Intuition (Per)
         * Logic (Int)
         * Lore (Int)
         * Medicae (Int)
         * Melee (WS)
         * Navigation (Int)
         * Presence (Will)
         * Piloting (Agi)
         * Psychic Might (Will)
         * Ranged (BS)
         * Rapport (Fel)
         * Reflexes (Agi)
         * Stealth (Agi)
         * Tech (Int)
         */
        public int Athletics { get; set; }
        public int Awareness { get; set; }
        public int Dexterity { get; set; }
        public int Discipline { get; set; }
        public int Fortitude { get; set; }
        public int Intuition { get; set; }
        public int Linguistics { get; set; }
        public int Logic { get; set; }
        public int Lore { get; set; }
        public int Medicae { get; set; }
        public int Melee { get; set; }
        public int Navigation { get; set; }
        public int Presence { get; set; }
        public int Piloting { get; set; }
        public int PsychicMastery { get; set; }
        public int Ranged { get; set; }
        public int Rapport { get; set; }
        public int Reflexes { get; set; }
        public int Stealth { get; set; }
        public int Tech { get; set; }


        private StatsSingleton()
        {
            // Set default values for all stats
            WeaponSkill = 0;
            BallisticsSkill = 0;
            Strength = 0;
            Toughness = 0;
            Agility = 0;
            Intelligence = 0;
            Perception = 0;
            Willpower = 0;
            Fellowship = 0;
            EXP = 0;
            Solars = 0;

            //load all origins
            AllOrigins = new OriginList();
            AllOrigins = AllOrigins.Deserialize(); //this feels wonky
            AllSkillAdvances = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            AllStatAdvances = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            AllSpecializations = new Dictionary<string, int>(); //this is filled as we get them. Its also a player choice thing.
            PreviousOrigin = new Origin();
            PreviousOrigin.Name = "None"; //compare to this to know there is nothing to revert.
            CurrentOrigin = new Origin();
            AllFactions = new FactionList();
            AllFactions = AllFactions.Deserialize();
            CurrentDuty = new Duty();
            PreviousDuty = new Duty();
            PreviousDuty.Name = "None";
        }
    }
}
    
