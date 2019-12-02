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
            if (Equip)
            {
                //appdata.equip
            }
            else
            {
                switch (StatChanged)
                {
                    case ("CurrentHealth"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._CurrentHealth *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._CurrentHealth += ChangeAmount;
                        }
                        break;
                    case ("CurrentEXP"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._CurrentEXP *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._CurrentEXP += ChangeAmount;
                        }
                        break;
                    case ("CurrentChi"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._CurrentChi *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._CurrentChi += ChangeAmount;
                        }
                        break;
                    case ("CurrentStamina"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._CurrentStamina *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._CurrentStamina += ChangeAmount;
                        }
                        break;
                    case ("Strength"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Strength *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Strength += ChangeAmount;
                        }
                        break;
                    case ("BasicAttack"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._BasicAttack *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._BasicAttack += ChangeAmount;
                        }
                        break;
                    case ("StrikeSupers"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._StrikeSupers *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._StrikeSupers += ChangeAmount;
                        }
                        break;
                    case ("ChiBlastSupers"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._ChiBlastSupers *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._ChiBlastSupers += ChangeAmount;
                        }
                        break;
                    case ("Athletics"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Athletics *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Athletics += ChangeAmount;
                        }
                        break;
                    case ("Power"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Power *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Power += ChangeAmount;
                        }
                        break;
                    case ("Dexterity"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Dexterity *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Dexterity += ChangeAmount;
                        }
                        break;
                    case ("Acrobatics"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Acrobatics *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Acrobatics += ChangeAmount;
                        }
                        break;
                    case ("Stealth"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Stealth *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Stealth += ChangeAmount;
                        }
                        break;
                    case ("Speed"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Speed *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Speed += ChangeAmount;
                        }
                        break;
                    case ("Endurance"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Endurance *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Endurance += ChangeAmount;
                        }
                        break;
                    case ("Constitution"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Constitution *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Constitution += ChangeAmount;
                        }
                        break;
                    case ("Health"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Health *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Health += ChangeAmount;
                        }
                        break;
                    case ("Stamina"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Stamina *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Stamina += ChangeAmount;
                        }
                        break;
                    case ("Chi"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Chi *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Chi += ChangeAmount;
                        }
                        break;
                    case ("Resistance"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Resistance *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Resistance += ChangeAmount;
                        }
                        break;
                    case ("Intelligence"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Intelligence *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Intelligence += ChangeAmount;
                        }
                        break;
                    case ("Technology"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Technology *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Technology += ChangeAmount;
                        }
                        break;
                    case ("Combat"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Combat *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Combat += ChangeAmount;
                        }
                        break;
                    case ("Wisdom"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Wisdom *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Wisdom += ChangeAmount;
                        }
                        break;
                    case ("Insight"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Insight *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Insight += ChangeAmount;
                        }
                        break;
                    case ("Medicine"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Medicine *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Medicine += ChangeAmount;
                        }
                        break;
                    case ("Perception"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Perception *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Perception += ChangeAmount;
                        }
                        break;
                    case ("Charisma"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Charisma *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Charisma += ChangeAmount;
                        }
                        break;
                    case ("Deception"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Deception *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Deception += ChangeAmount;
                        }
                        break;
                    case ("Intimidation"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Intimidation *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Intimidation += ChangeAmount;
                        }
                        break;
                    case ("Performace"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Performace *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Performace += ChangeAmount;
                        }
                        break;
                    case ("Persuasion"):
                        if (ChangeType == '*')
                        {
                            AppData.Instance()._Persuasion *= ChangeAmount;
                        }
                        else if (ChangeType == '+')
                        {
                            AppData.Instance()._Persuasion += ChangeAmount;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: incorrect enchantment type");
                        break;
                }
                mainBase.Use();
            }
            
        }
    }
}
