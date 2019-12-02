using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbzdnd
{
    public abstract class BaseItem
    {
        protected bool Equip;
        public BaseItem() { }
        virtual public void Use() { }
        public bool _Equip { get => Equip;}
    }
}
