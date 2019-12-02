using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbzdnd.Items
{
    class InitialUseItem : BaseItem
    {
        public InitialUseItem() : base()
        {
            Equip = false;
        }

        public override void Use()
        {
            AppData.Instance().refreshForms();
        }
    }
}
