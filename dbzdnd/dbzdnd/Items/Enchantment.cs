using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbzdnd.Items
{
    class Enchantment : BaseItem
    {
        private BaseItem mainBase;
        private char ChangeType;
        private int ChangeAmount;
        private string StatChanged;
        public Enchantment(BaseItem enchantedItem, char Type, int Amount, string Stat) : base()
        {
            mainBase = enchantedItem;
            Equip = mainBase._Equip;
            ChangeType = Type;
            ChangeAmount = Amount;
            StatChanged = Stat;
        }

        public override void Use()
        {
            switch (StatChanged)
            {
                case ("Level"):
                    break;
                case ("StimCount"):
                    break;
                case ("RecoveryCount"):
                    break;
                    /* EnergyCount
                        CurrentHealth
                        CurrentEXP
                        CurrentChi
                        CurrentStamina
                        Strength
                        BasicAttack, StrikeSupers, ChiBlastSupers, Athletics, Power;
        private int Dexterity, Acrobatics, Stealth, Speed, Endurance;
        private int Constitution, Health, Stamina, Chi, Resistance;
        private int Intelligence, Technology, Combat;
        private int Wisdom, Insight, Medicine, Perception;
        private int Charisma, Deception, Intimidation, Performace, Persuasion;*/
    }
        }
    }
}
