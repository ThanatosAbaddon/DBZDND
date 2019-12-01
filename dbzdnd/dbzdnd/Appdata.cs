using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbzdnd
{
    //A class to store every variable and save / load it from file.
    class AppData
    {
        #region "variables"
        private string PlayerName, Name, Race, Height, Weight, Eyes, Skin, Alignment, Faction, Languages;
        private bool Male;
        private decimal Credits;
        private int Level, StimCount, RecoveryCount, EnergyCount, StatPoints, SpecPoints, Age;
        private int CurrentHealth, CurrentEXP, CurrentChi, CurrentStamina;
        private int Strength, BasicAttack, StrikeSupers, ChiBlastSupers, Athletics, Power;
        private int Dexterity, Acrobatics, Stealth, Speed, Endurance;
        private int Constitution, Health, Stamina, Chi, Resistance;
        private int Intelligence, Technology, Combat;
        private int Wisdom, Insight, Medicine, Perception;
        private int Charisma, Deception, Intimidation, Performace, Persuasion;
        private static Network saveLoadLocation;
        

        /// <summary>
        /// The single instance of the object.
        /// </summary>
        /// 
        private static AppData singleObject = null;
        private readonly static Object padlock = new Object();
        private MainForm _MainForm;

        #endregion

        #region "Getters and Setters"
        public string _PlayerName { get => PlayerName; set => PlayerName = value; }
        public string _Name { get => Name; set => Name = value; }
        public string _Race { get => Race; set => Race = value; }
        public string _Height { get => Height; set => Height = value; }
        public string _Weight { get => Weight; set => Weight = value; }
        public string _Eyes { get => Eyes; set => Eyes = value; }
        public string _Skin { get => Skin; set => Skin = value; }
        public string _Alignment { get => Alignment; set => Alignment = value; }
        public string _Faction { get => Faction; set => Faction = value; }
        public string _Languages { get => Languages; set => Languages = value; }
        public bool _Male { get => Male; set => Male = value; }
        public decimal _Credits { get => Credits; set => Credits = value; }
        public int _Level { get => Level; set => Level = value; }
        public int _StimCount { get => StimCount; set => StimCount = value; }
        public int _RecoveryCount { get => RecoveryCount; set => RecoveryCount = value; }
        public int _EnergyCount { get => EnergyCount; set => EnergyCount = value; }
        public int _StatPoints { get => StatPoints; set => StatPoints = value; }
        public int _SpecPoints { get => SpecPoints; set => SpecPoints = value; }
        public int _Age { get => Age; set => Age = value; }
        public int _CurrentHealth { get => CurrentHealth; set => CurrentHealth = value; }
        public int _CurrentEXP { get => CurrentEXP; set => CurrentEXP = value; }
        public int _CurrentChi { get => CurrentChi; set => CurrentChi = value; }
        public int _CurrentStamina { get => CurrentStamina; set => CurrentStamina = value; }
        public int _Strength { get => Strength; set => Strength = value; }
        public int _BasicAttack { get => BasicAttack; set => BasicAttack = value; }
        public int _StrikeSupers { get => StrikeSupers; set => StrikeSupers = value; }
        public int _ChiBlastSupers { get => ChiBlastSupers; set => ChiBlastSupers = value; }
        public int _Athletics { get => Athletics; set => Athletics = value; }
        public int _Power { get => Power; set => Power = value; }
        public int _Dexterity { get => Dexterity; set => Dexterity = value; }
        public int _Acrobatics { get => Acrobatics; set => Acrobatics = value; }
        public int _Stealth { get => Stealth; set => Stealth = value; }
        public int _Speed { get => Speed; set => Speed = value; }
        public int _Endurance { get => Endurance; set => Endurance = value; }
        public int _Constitution { get => Constitution; set => Constitution = value; }
        public int _Health { get => Health; set => Health = value; }
        public int _Stamina { get => Stamina; set => Stamina = value; }
        public int _Chi { get => Chi; set => Chi = value; }
        public int _Resistance { get => Resistance; set => Resistance = value; }
        public int _Intelligence { get => Intelligence; set => Intelligence = value; }
        public int _Technology { get => Technology; set => Technology = value; }
        public int _Combat { get => Combat; set => Combat = value; }
        public int _Wisdom { get => Wisdom; set => Wisdom = value; }
        public int _Insight { get => Insight; set => Insight = value; }
        public int _Medicine { get => Medicine; set => Medicine = value; }
        public int _Perception { get => Perception; set => Perception = value; }
        public int _Charisma { get => Charisma; set => Charisma = value; }
        public int _Deception { get => Deception; set => Deception = value; }
        public int _Intimidation { get => Intimidation; set => Intimidation = value; }
        public int _Performace { get => Performace; set => Performace = value; }
        public int _Persuasion { get => Persuasion; set => Persuasion = value; }
        public static Network _saveLoadLocation { get => saveLoadLocation; set => saveLoadLocation = value; }
        #endregion

        #region "loading"
        /// <summary>
        /// Constructor (DON'T USE, USE Instance() INSTEAD!!!)
        /// </summary>
        public AppData()
        {
            PlayerName = "";
            Name = "";
            Race = "";
            Height = "";
            Weight = "";
            Eyes = "";
            Skin = "";
            Alignment = "";
            Faction = "";
            Languages = "";
            Male = true;
            Credits = 0;
            Level = 0;
            StimCount = 0;
            RecoveryCount = 0;
            EnergyCount = 0;
            StatPoints = 0;
            SpecPoints = 0;
            Age = 0;
            CurrentHealth = 0;
            CurrentEXP = 0;
            CurrentChi = 0;
            CurrentStamina = 0;
            Strength = 0;
            BasicAttack = 0;
            StrikeSupers = 0;
            ChiBlastSupers = 0;
            Athletics = 0;
            Power = 0;
            Dexterity = 0;
            Acrobatics = 0;
            Stealth = 0;
            Speed = 0;
            Endurance = 0;
            Constitution = 0;
            Health = 0;
            Stamina = 0;
            Chi = 0;
            Resistance = 0;
            Intelligence = 0;
            Technology = 0;
            Combat = 0;
            Wisdom = 0;
            Insight = 0;
            Medicine = 0;
            Perception = 0;
            Charisma = 0;
            Deception = 0;
            Intimidation = 0;
            Performace = 0;
            Persuasion = 0;
        }

        /// <summary>
        /// Loads the appData data
        /// </summary>
        /// <returns></returns>
        public static AppData LoadAppData(string name, string playerData, Network networkLocation = null)
        {
            AppData currentAppData;

            currentAppData = JsonConvert.DeserializeObject<AppData>(playerData);
            _saveLoadLocation = networkLocation;
            
            return currentAppData;
        }

        /// <summary>
        /// Used when this method is called from the initial forms. Creates a new appdata based on what the user wants to use.
        /// </summary>
        /// <param name="IP">The server's IP</param>
        /// <param name="online">Checks if the user wants to go online or offline</param>
        /// <param name="name">user's name, used to load the save</param>
        /// <param name="loadLocation">online / offline / none loading</param>
        /// <returns></returns>
        public static AppData Instance(string name, string playerData, Network NetworkLocation = null)
        {

            lock (padlock)
            {
                if (singleObject == null)
                {
                    //loads the saved appdata
                    singleObject = LoadAppData(name, playerData, NetworkLocation);
                }
                singleObject._MainForm = new MainForm();
                singleObject._MainForm.Show();
                return singleObject;
            }

        }

        /// <summary>
        /// Returns a single static object of this class
        /// </summary>
        public static AppData Instance()
        {
            lock (padlock)
            {
                return singleObject;
            }

        }
        #endregion

        #region "saving"
        public static void saveAppData()
        {
            Console.WriteLine("Local Auto Saving");
            
            string fileString = singleObject._PlayerName + "\n" + singleObject + "\n" + DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            //Save local file
            File.WriteAllText(singleObject._PlayerName + ".json", fileString);

            Console.WriteLine("Local Saved");

            if (_saveLoadLocation != null)
            {
                _saveLoadLocation.Save();
            }
        }

        public void startTimer()
        {
            if(_MainForm != null)
            {
                _MainForm.startTimer();
            }
            
        }

        override
        public String ToString()
        {
            return JsonConvert.SerializeObject(singleObject);
        }

        #endregion
    }

}
