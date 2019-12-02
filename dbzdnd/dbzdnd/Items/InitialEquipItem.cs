using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbzdnd
{
    class InitialEquipItem : BaseItem
    {
        public InitialEquipItem() : base()
        {
            Equip = true;
        }

        public override void Use() {
            
        }
    }
}
